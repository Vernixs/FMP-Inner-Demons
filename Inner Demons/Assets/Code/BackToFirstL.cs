using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToFirstL : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerController.lastCall = FindObjectOfType<PlayerController>().transform.position;
            SceneManager.LoadScene(2);
        }
    }
}
