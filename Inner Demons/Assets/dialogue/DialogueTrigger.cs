using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    bool dialoguePanel = false;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    public void Update()
    {   
        
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            //Debug.Log("player");
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Debug.Log("dialogue");
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                dialoguePanel = true;
            }
        }
        else
        {
            visualCue.SetActive(false);
        }


    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
