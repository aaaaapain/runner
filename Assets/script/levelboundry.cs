using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelboundry : MonoBehaviour
{
    public static float leftside=-4f;
    public static float rightside=5.5f;
    public float interanlleft;
    public float interanlright;

    private void Update()
    {
        interanlleft=leftside;
        interanlright=rightside;
    }
}
