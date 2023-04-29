using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class level : MonoBehaviour
{
    public GameObject[] section;
    public GameObject spw;
    public GameObject sect;
    public float spawner =0.0f;
    public float counter ;
    public bool creatingsection=false;
    public int secnum;
    public Vector3 spn;
    private float i;
    private float k = 30.0f;



    private void Start()
    { 
            StartCoroutine(genertsection());
            
    }
   
    IEnumerator genertsection()
    {
      
        while (true)
        {
            secnum = Random.Range(0, 3);
            Instantiate(section[secnum], new Vector3(0, 0.5f, k), Quaternion.identity);
            k = k + 30;
            yield return new WaitForSeconds(5);
            
        }
    }
   

}
