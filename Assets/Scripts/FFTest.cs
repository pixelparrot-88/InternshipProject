using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FFTest : MonoBehaviour
{
    public Image fadeBoard;


    // Start is called before the first frame update
    public void fadeIn()
    {
        fadeBoard.canvasRenderer.SetAlpha(0.0f);
        fadeBoard.CrossFadeAlpha(1, 2, false);
    }

    public void fadeOut()
    {
        fadeBoard.canvasRenderer.SetAlpha(1.0f);
        fadeBoard.CrossFadeAlpha(0, 2, false);
    }
}
