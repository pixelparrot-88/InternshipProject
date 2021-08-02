using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugConsole : MonoBehaviour
{
    string text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Please input your value for the fame bar: ");
        //FamePara fm = new FamePara();

        FamePara fm = gameObject.GetComponent<FamePara>();

        text = fm.GetFameValue().ToString();
        Debug.Log(text);
    }
}
