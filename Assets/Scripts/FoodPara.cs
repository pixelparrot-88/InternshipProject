using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodPara : MonoBehaviour
{

    public Image[] foodPoints;

    float food, maxFood = 100;

    // Start is called before the first frame update
    public void Start()
    {
        food = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        if (food > maxFood) food = maxFood;

        FoodBarFiller();
    }

    void FoodBarFiller()
    {
        for (int i = 0; i < foodPoints.Length; i++)
        {
            foodPoints[i].enabled = !DisplayFoodPoint(food, i);
        }
    }

    bool DisplayFoodPoint(float _food, int pointNubmber)
    {
        return ((pointNubmber * 10) >= _food);
    }

    public void Minus(float minusPoints)
    {
        if (food > 0)
            food -= minusPoints;
    }

    public void Plus(float plusPoints)
    {
        if (food < maxFood)
            food += plusPoints;
    }

    //GetSet
    public void SetFoodValue(float a)
    {
        food = a;
    }

    public float GetFoodValue()
    {
        return food;
    }
}
