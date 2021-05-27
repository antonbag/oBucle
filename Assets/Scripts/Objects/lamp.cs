using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationAngle = 1f;
    public float balanceo = 0.2f;
    float seno;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seno = Mathf.Sin(balanceo)*0.1f;
        transform.Rotate(seno,rotationAngle,seno);
    }
}
