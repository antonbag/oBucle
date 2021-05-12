using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sferaMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sun;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Sin(Time.time), 1.0f, 2.28f);

        sun.transform.rotation = Quaternion.Euler((Mathf.Sin(Time.time)*20)+10,0,0);

    }
}
