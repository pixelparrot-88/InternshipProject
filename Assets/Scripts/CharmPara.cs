using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmPara : MonoBehaviour
{

    public Image[] charmPoints;

    float charm, maxCharm = 100;

    // Start is called before the first frame update
    public void Start()
    {
        charm = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        if (charm > maxCharm) charm = maxCharm;

        CharmBarFiller();
    }

    void CharmBarFiller()
    {
        for (int i = 0; i < charmPoints.Length; i++)
        {
            charmPoints[i].enabled = !DisplayCharmPoint(charm, i);
        }
    }

    bool DisplayCharmPoint(float _charm, int pointNubmber)
    {
        return ((pointNubmber * 10) >= _charm);
    }

    public void Minus(float minusPoints)
    {
        if (charm > 0)
            charm -= minusPoints;
    }

    public void Plus(float plusPoints)
    {
        if (charm < maxCharm)
            charm += plusPoints;
    }

    //GetSet
    public void SetCharmValue(float a)
    {
        charm = a;
    }

    public float GetCharmValue()
    {
        return charm;
    }
}
