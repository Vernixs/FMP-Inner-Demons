using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public QuestObject[] quests;
    public bool[] questCompleted;

    public DialogueManager theDM;

    void Start()
    {
        questCompleted = new bool[quests.Length];
    }

    public void ShowQuestText(string questText)
    {
        
    }
}
