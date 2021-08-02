using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FamePara : MonoBehaviour
{

    public Image[] famePoints;

    float fame = 40, maxFame = 100;

    // Start is called before the first frame update
    public void Start()
    {
        fame = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        if (fame > maxFame)
        {
            fame = maxFame;
        }

        FameBarFiller(); // it fills the bar.
    }

    void FameBarFiller()
    {
        for (int i = 0; i < famePoints.Length; i++)
        {
            famePoints[i].enabled = !DisplayFamePoint(fame, i);
        }
    }

    bool DisplayFamePoint(float _fame, int pointNubmber)
    {
        return ((pointNubmber * 10) >= _fame);
    }

    public void Minus(float minusPoints)
    {
        if (fame > 0)
            fame -= minusPoints;


    }

    public void Plus(float plusPoints)
    {
        if (fame < maxFame)
            fame += plusPoints;
    }
    //GetSet
    public void SetFameValue(float a)
    {
        fame = a;
    }

    public float GetFameValue()
    {
        return fame;
    }
}
