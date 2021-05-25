using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFall : MonoBehaviour
{
    public Vector3 where;
      float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //volver al inicio si te sales de la pantallas
        y = this.transform.position.y; 
        if(y < -10){
            transform.position = where;
        } 
    }
}
