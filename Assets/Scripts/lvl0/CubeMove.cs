using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    Rigidbody rb;
    float _rot = 0;
    float randomInit;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        randomInit = Random.Range(10.0f, 50.0f);
    }

    // Update is called once per frame
    void Update()
    {

        _rot += Time.deltaTime*10.0f;

           transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Sin(Time.time)+4.55f);
           //transform.Rotate = Quaternion() new Vector3(0);
            transform.rotation = Quaternion.Euler(randomInit+_rot/100,_rot,90+(randomInit/2)-_rot/3);
    }
}


