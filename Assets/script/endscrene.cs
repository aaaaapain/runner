using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endscrene : MonoBehaviour
{
    public GameObject livecoins;
    public GameObject livedis;
    public GameObject endscren;
    public bool gameOver;
    
    private void Update()
    {
     if(gameOver)
            StartCoroutine(endsequence());
    }
    IEnumerator endsequence()
    { 
            yield return new WaitForSeconds(3);
            livecoins.SetActive(false);
            livedis.SetActive(false);
            endscren.SetActive(true);
        
    }
}
