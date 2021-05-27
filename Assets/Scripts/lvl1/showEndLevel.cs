using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showEndLevel : MonoBehaviour
{
    GameObject _endLevel;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        _endLevel = GameObject.Find("LevelComplete");
    }

    // Update is called once per frame
    void Update()
    {
        y = this.transform.position.y; 
        if(y < -10){
           _endLevel.transform.position = new Vector3(0,0,0);
        }    
    }
}
