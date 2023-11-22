using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControll : MonoBehaviour
{
    
    public GameObject light;
    private bool left=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.transform.Rotate(0,-1f,0);
    }
}
