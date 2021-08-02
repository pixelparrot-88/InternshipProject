using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AnimationTest : MonoBehaviour
{
    public GameObject playGameAnime;
    int activating;

    private float delayBeforeLoading = 6.5f;
    private float timeElapsed = 0f;

    // Start is called before the first frame update
    //private void OnPointerClick(PointerEventData eventData)
    //{
    //    activating = eventData.clickCount;

    //    if (activating == 1)
    //    {
    //        playGameAnime.SetActive(true);

    //    }
    //}

    //void Update()
    //{
    //    timeElapsed += Time.deltaTime;


    //    if (timeElapsed > delayBeforeLoading)
    //     {
    //           playGameAnime.SetActive(false);
    //     }

    //}



    public void WhyisnotWorking()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            playGameAnime.SetActive(false);
        }
    }
}


