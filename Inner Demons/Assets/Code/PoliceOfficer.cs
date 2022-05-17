using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PoliceOfficer : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    AIPath path;
    bool dialoguePanel = false;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        path = FindObjectOfType<AIPath>();
    }

    public void Update()
    {

        if ((playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying) || (DialogueManager.GetInstance().dialogueIsPlaying))
        {
         DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
         dialoguePanel = true;
        }



    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("hello");

        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
            path.canMove = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            path.canMove = true;
            playerInRange = false;
        }
    }
}
