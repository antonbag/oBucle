using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solMov : MonoBehaviour
{

    public float vel = 2f;
    private float _rot = 130; 
    bool _actualiza;
    bool _subida;
    float _miTime = 0;
    // Start is called before the first frame update


    void Start()
    {
        _subida = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(_miTime >= 5){
           
            _miTime = 0;
            _actualiza = !_actualiza;
        }

        this.actualizaSombras();
         _miTime += Time.deltaTime;

    }

    void actualizaSombras(){

        if(_miTime <= 2) return;

        if(_rot <=110){
            _subida = true;
        }

        if(_rot >=150){
            _subida = false;
        }

        if(_actualiza){
            if(_subida) _rot += Time.deltaTime*vel;
            if(!_subida) _rot -= Time.deltaTime*vel;
                      
            transform.rotation = Quaternion.Euler(45+_rot/100,_rot,90);
        }


    }

}
