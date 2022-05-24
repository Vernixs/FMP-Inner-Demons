using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class PoliceOfficer : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    
    AIPath path;
    AIDestinationSetter nonplayer;
    bool dialoguePanel = false;
    [SerializeField]GameObject diffTarget;

    private bool playerInRange;

    bool spoken = false;

    private void Awake()
    {
        playerInRange = false;
        path = FindObjectOfType<AIPath>();
        nonplayer = FindObjectOfType<AIDestinationSetter>();
    }

    public void Update()
    {
        if (spoken == false)
        {
            if ((playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying))
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                dialoguePanel = true;
                spoken = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("hello");

        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
            
        }

        if (collider.gameObject.tag == "Go Away")
        {
            nonplayer.target = FindObjectOfType<PlayerController>().transform;

            Debug.Log(nonplayer.target);

            spoken = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //path.canMove = true;
            playerInRange = false;
            nonplayer.target = diffTarget.transform;

        }
    }
}
