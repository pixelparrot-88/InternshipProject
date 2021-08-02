using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IPointerClickHandler
{


    int tap;
    string StatusEvent = "";

    public GameObject ButtonPlayGame, ButtonChatting, PlayMusic, DoNothing;



    public void OnPointerClick(PointerEventData eventData)
    {
        tap = eventData.clickCount;

        if (tap == 2)
        {
            SceneManager.LoadScene("MainScene"); 
        }

    }

    public void Update()
    {
        //here goes real time actions

      
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }


    public void OnclickPlayGame()
    {
        StatusEvent = "FameEvent01";

    }


}
