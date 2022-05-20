using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;


    bool dialoguePanel = false;
    bool conversationStart = false;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
    }

    public void Update()
    {

        if ((playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying) || conversationStart)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {
                conversationStart = true;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                dialoguePanel = true;

                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;



            }
        }



    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("hello");

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
