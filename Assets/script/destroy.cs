using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject scene;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(scene, 30);
    }
}
