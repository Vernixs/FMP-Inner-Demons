using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class CanMove : MonoBehaviour
{

    AIPath path;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        path = FindObjectOfType<AIPath>();



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        path.canMove = false;
        
    }

}
