using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappyPara : MonoBehaviour
{

    public Image[] happyPoints;

    float happy, maxHappy = 100;

    // Start is called before the first frame update
    public void Start()
    {
        happy = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        if (happy > maxHappy) happy = maxHappy;

        HappyBarFiller();
    }

    void HappyBarFiller()
    {
        for (int i = 0; i < happyPoints.Length; i++)
        {
            happyPoints[i].enabled = !DisplayHappyPoint(happy, i);
        }
    }

    bool DisplayHappyPoint(float _happy, int pointNubmber)
    {
        return ((pointNubmber * 10) >= _happy);
    }

    public void Minus(float minusPoints)
    {
        if (happy > 0)
            happy -= minusPoints;
    }

    public void Plus(float plusPoints)
    {
        if (happy < maxHappy)
            happy += plusPoints;
    }

    //GetSet
    public void SetHappyValue(float a)
    {
        happy = a;
    }

    public float GetHappyValue()
    {
        return happy;
    }
}
