using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomGenerator : MonoBehaviour
{

    public GameObject TextBox;
    public int TheNumber;

    // Start is called before the first frame update
    public void RandomGenerate()
    {
        TheNumber = Random.Range(1, 1000);
        TextBox.GetComponent<Text>().text = "" + TheNumber;

    }

}