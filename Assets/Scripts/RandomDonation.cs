using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDonation : MonoBehaviour
{
    public GameObject donations_Text;
    public GameObject donations02_Text;
    int money,randomNumber;

    int g500 = 500, g1000 = 1000;

    public void Start()
    {
        money = 3000;
        donations02_Text.GetComponent<Text>().text = "Donations";
    }

    // Update is called once per frame
    public void Update()
    {
        if (money < 0)
            money = 0;


        if (money >= 0)
        {
            donations_Text.GetComponent<Text>().text = money.ToString();
        }
        
    }

    public void AddMoney()
    {
        randomNumber = Random.Range(1, 1000);
        donations02_Text.GetComponent<Text>().text = "+1! :"+ randomNumber.ToString();
        money += randomNumber;


        //money = money + randomNumber;
    }

    public void LessMoney()
    {
        randomNumber = Random.Range(1, 1000);
        money -= randomNumber;
    }

    public void SpendMoney500()
    {
        money -= g500;
    }
    public void SpendMoney1000()
    {
        money -= g1000;
    }

    public int GetMoney()
    {
        return money;
    }


}
