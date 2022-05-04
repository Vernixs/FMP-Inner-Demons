using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class CanMove : MonoBehaviour
{

    AIPath path;
    dialogHolder dMan;
    DialogueManager dMans;

    // Start is called before the first frame update
    void Start()
    {
        path = FindObjectOfType<AIPath>();
        dMan = FindObjectOfType<dialogHolder>();
        dMans = FindObjectOfType<DialogueManager>();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        path.canMove = false;
        dMans.dBox.SetActive(true);
    }

}
