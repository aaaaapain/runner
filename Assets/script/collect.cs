using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        coinscounter.coincount ++;
        this.gameObject.SetActive(false);
    }
}
