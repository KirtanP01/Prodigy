using System;
using System.Collections;
using UnityEngine;

public class AnimateV2 : MonoBehaviour
{
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;

    void Start()
    {
        egg1.SetActive(false);
        egg2.SetActive(false);
        egg3.SetActive(false);
        egg4.SetActive(false);

        StartCoroutine(Timer(1));
    }

    IEnumerator Timer(int time)
    {
        yield return new WaitForSeconds(time);
        egg1.SetActive(true);
        egg2.SetActive(false);
        egg3.SetActive(false);
        egg4.SetActive(false);

        yield return new WaitForSeconds(time);
        egg1.SetActive(false);
        egg2.SetActive(true);
        egg3.SetActive(false);
        egg4.SetActive(false);

        yield return new WaitForSeconds(time);
        egg1.SetActive(false);
        egg2.SetActive(false);
        egg3.SetActive(true);
        egg4.SetActive(false);

        yield return new WaitForSeconds(time);
        egg1.SetActive(false);
        egg2.SetActive(false);
        egg3.SetActive(false);
        egg4.SetActive(true);

        yield return new WaitForSeconds(time);
        egg1.SetActive(false);
        egg2.SetActive(false);
        egg3.SetActive(false);
        egg4.SetActive(false);
    }

    /*public static void DelayAction(int millisecond)
    //Action action
    {
        var timer = new DispatcherTimer();
        timer.Tick += delegate

        {
            //action.Invoke();
            timer.Stop();
        };

        timer.Interval = TimeSpan.FromMilliseconds(millisecond);
        timer.Start();
    }*/
}
