using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscounter : MonoBehaviour
{
     public static int  coincount;
     public GameObject coincountDisplay;
     public GameObject coinendDisplay;
    void Update()
    {
        coincountDisplay.GetComponent<Text>().text = "" + coincount;
        coinendDisplay.GetComponent<Text>().text = "" + coincount;
    }
}
