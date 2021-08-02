using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IndexScript : MonoBehaviour
{


    public GameObject Step01Enable, Step02Enable, Step03Enable;

    public GameObject FameGague;

    FamePara csfame;


    //Always change this if loading is slected to false
    bool LoadStart = false;

    //Stats to keep track for the player
    float Gold, fame, food, charm, intelli, happ;

    //play money to add per night
    int MondayAdd50, MondayAdd100;

    //check if the player failed the game
    bool failedGame = false;

    //play which event is going to play
    string EventPositon = "Position0";
    //events
    bool FameEvent01 = false;
    bool FameEvent02 = false;
    bool FameEvent03 = false;

    bool PlayGame = false;
    bool PlayContinuebtn = false;



    // Start is called before the first frame update
    void Start()
    {

     

    }

    // Update is called once per frame
    void Update()
    {

        InitializeIndex();
      //  EventStart();


    }


    public void InitializeIndex()
    {


        if (LoadStart == true)
        {
            //todo: load file from computer to game from past played round
            //does nothing yet.
        }

        //load initial values if it's the first time running the game
        if (LoadStart == false)
        {

            Gold = 4;
            fame = 4;
            food = 4;
            charm = 4;
            intelli = 4;
            happ = 4;

            LoadStart = true;

        }
    }

    public void EventStart()
    {

        switch (EventPositon)
        {
            case "Position0":

                Step01Enable.SetActive(true);

                if (PlayGame == true)
                {
                    Step01Enable.SetActive(false);
                    Step02Enable.SetActive(true);

                    if (PlayContinuebtn == true)
                    {
                        Step02Enable.SetActive(false);
                       
                        fame -= 0.1f;
                  
                        csfame = FindObjectOfType<FamePara>();
                        csfame.SetFameValue(fame);

                        Step03Enable.SetActive(true);

                    }


                }

                //EventPositon = "FameEvent01";

                break;

            case "FameEvent01":


            case "FameEvent02":

            case "FameEvent03":



            default:
                break;
        }



    }




    public void ButtonPlayGameClicked()
    {

        PlayGame = true;
    }

    public void ButtonPlayGameContinuebtn()

    {
        PlayContinuebtn = true;
    }


}
