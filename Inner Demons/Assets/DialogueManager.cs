using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dBox;
    public Text dText;
    dialogHolder holder;

    public bool dialogActive;

    void Start()
    {
        holder = FindObjectOfType<dialogHolder>();
    }

    // Update is called once per frame
    void Update()
    {
       // dText.text  = dialogLines[currentLine]
    }

    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        Debug.Log("Nope?");
    }
}
