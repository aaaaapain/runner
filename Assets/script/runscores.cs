using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runscores : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disendDisplay;
    public int disrun;
    public bool addingDis=false;
    private float rund = 0.35F;
    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }  
    }
    IEnumerator AddingDis()
    {
        disrun++;
        disDisplay.GetComponent<Text>().text=""+disrun;
        disendDisplay.GetComponent<Text>().text = "" + disrun;
        yield return new WaitForSeconds(rund);
        addingDis = false;
    }
}
