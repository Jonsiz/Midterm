using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;


    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        //Counts Miliseconds in delta-time, adds a +1 to seconds, upon reaching 11.
        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        //Counts seconds, upon reach 9, sets itself to 0, then adds a 1 to the next digit over, upon reaching 61seconds, adds a +1 to minutes and sets itseld to 0.
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
        }
        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        //Counts minutes, upon reaching 9, sets itself to 0 and adds a +1 to the next digit over.
        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }
    }
}
