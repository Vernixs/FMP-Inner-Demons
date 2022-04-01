using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolder : MonoBehaviour
{

    public string dialogue;
    DialogueManager dMan;

    bool canTalk = false;
    bool dismissedThisFrame = false;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canTalk)
            {
                if (dMan.dialogActive == false)
                {
                    dMan.ShowBox(dialogue);
                }
                else
                {
                    dMan.dBox.SetActive(false);
                    dMan.dialogActive = false;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            canTalk = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            canTalk = false;

            if(dMan.dialogActive == true)
            {
                dMan.dBox.SetActive(false);
                dMan.dialogActive = false;
            }
        }
    }
}
