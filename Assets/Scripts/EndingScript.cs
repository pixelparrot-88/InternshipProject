using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScript : MonoBehaviour
{
    FamePara fame;
    ConnectPara connection;
    FoodPara food;
    CharmPara charm;
    IntellPara intell;
    HappyPara happy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get
        fame = FindObjectOfType<FamePara>();
        float fa = fame.GetFameValue();

        connection = FindObjectOfType<ConnectPara>();
        float co = connection.GetConnectionValue();
        
        food = FindObjectOfType<FoodPara>();
        float fo = food.GetFoodValue();
        
        charm = FindObjectOfType<CharmPara>();
        float ch = charm.GetCharmValue();
        
        intell = FindObjectOfType<IntellPara>();
        float inte = intell.GetIntellValue();
        
        happy = FindObjectOfType<HappyPara>();
        float ha = happy.GetHappyValue();

        //Set

        //fame
        if (fa >= 100) 
        {
            fa = 100;
            fame.SetFameValue(fa);
            SceneManager.LoadScene("Ending_Good");
        }
        else if (fa <= 10)
        {
            SceneManager.LoadScene("Ending_Bad");
        }

        //Connection
        if (co >= 100)
        {
            co = 100;
            connection.SetConnectionValue(co);
            SceneManager.LoadScene("Ending_Good");
        }
        else if (co <= 10)
        {
            SceneManager.LoadScene("Ending_Bad");
        }

        //Food
        if (fo >= 100)
        {
            fo = 100;
            food.SetFoodValue(fo);
            SceneManager.LoadScene("Ending_Good");
        }
        else if (fo <= 10)
        {
            SceneManager.LoadScene("Ending_Bad");
        }

        //Charm
        if (ch >= 100)
        {
            ch = 100;
            charm.SetCharmValue(ch);
            SceneManager.LoadScene("Ending_Good");
        }
        else if (ch <= 10)
        {
            SceneManager.LoadScene("Ending_Bad");
        }

        //Intelligence.
        if (inte >= 100)
        {
            inte = 100;
            intell.SetIntellValue(inte);
            SceneManager.LoadScene("Ending_Good");
        }
        else if (inte <= 10)
        {
            SceneManager.LoadScene("Ending_Bad");
        }

        //Happy
        if (ha >= 100)
        {
            ha = 100;
            happy.SetHappyValue(ha);
            SceneManager.LoadScene("Ending_Good");
        }
        else if (ha <= 10)
        {
            SceneManager.LoadScene("Ending_Bad");
        }
    }
}
