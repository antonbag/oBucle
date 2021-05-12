using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
           transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Sin(Time.time)+4.55f);
    }
}


