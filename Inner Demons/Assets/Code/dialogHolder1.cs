using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogHolder1 : MonoBehaviour
{

    public string dialogue;
    DialogueManager dMan1;

    bool canTalk = false;
    bool dismissedThisFrame = false;
    public string[] dialogLines;
    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dMan1 = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canTalk)
            {
                if (dMan1.dialogActive == false)
                {
                    dMan1.ShowBox(dialogue);
                }
                else
                {
                    //dMan.dBox.SetActive(false);
                    // dMan.dialogActive = false;
                    currentLine++;                }
            }
            
        }

        if (currentLine >= dialogLines.Length)
        {
            dMan1.dBox.SetActive(false);
            dMan1.dialogActive = false;

            currentLine = 0;
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

            if(dMan1.dialogActive == true)
            {
                dMan1.dBox.SetActive(false);
                dMan1.dialogActive = false;
            }
        }
    }

}
