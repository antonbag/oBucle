using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;
public class lvlCompObject : MonoBehaviour
{
    float x;

    public string overrideNextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x =+ 1.0f; 
        transform.Rotate(0f, x, 0f);

    }






}
