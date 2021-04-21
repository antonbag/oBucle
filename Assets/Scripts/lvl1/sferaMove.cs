using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sferaMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Sin(Time.time), 1.0f, 2.28f);

    }
}
