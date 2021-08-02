using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntellPara : MonoBehaviour
{

    public Image[] intellPoints;

    float intell, maxIntell = 100;

    // Start is called before the first frame update
    public void Start()
    {
        intell = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        if (intell > maxIntell) intell = maxIntell;

        IntellBarFiller();
    }

    void IntellBarFiller()
    {
        for (int i = 0; i < intellPoints.Length; i++)
        {
            intellPoints[i].enabled = !DisplayIntellPoint(intell, i);
        }
    }

    bool DisplayIntellPoint(float _intell, int pointNubmber)
    {
        return ((pointNubmber * 10) >= _intell);
    }

    public void Minus(float minusPoints)
    {
        if (intell > 0)
            intell -= minusPoints;
    }

    public void Plus(float plusPoints)
    {
        if (intell < maxIntell)
            intell += plusPoints;
    }

    //GetSet
    public void SetIntellValue(float a)
    {
        intell = a;
    }

    public float GetIntellValue()
    {
        return intell;
    }
}
