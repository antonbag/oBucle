using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           transform.position = new Vector3(-2.0f, 1.0f, Mathf.Sin(Time.time)-2.55f);
    }
}


