using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclecollision : MonoBehaviour
{
    public GameObject theplayer;
    public GameObject charmodel;
    public GameObject levelcontrole;
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        theplayer.GetComponent<player>().enabled = false;
        charmodel.GetComponent<Animator>().Play("Stumble Backwards");
        levelcontrole.GetComponent<runscores>().enabled = false;
        FindObjectOfType<endscrene>().gameOver = true;

    }
}
