using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public PlayerController player;

    public GameObject questWindow;
    public GameObject requirements;
    

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        //moneyText = quest.money.ToString();
        
        
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        player.quest = quest;
    }
}
