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
        playerInRange = true;
        visualCue.SetActive(true);
    }

    public void Awake()
    {
        if (npcInRange)
        {
            visualCue.SetActive(true);

            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                dialoguePanel = true;
            }
        }

        else
        {
            visualCue.SetActive(true);
        }

        // if (Input.GetKeyDown(KeyCode.B))
        // {
        //      dialoguePanel = true;
        //   }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "NPC")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "NPC")
        {
            playerInRange = false;
        }
    }
}
