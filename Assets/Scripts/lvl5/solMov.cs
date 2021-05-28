using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solMov : MonoBehaviour
{

    public float vel = 2f;
    float _rot = 130; 

    public float rot_min = 110;
    public float rot_max =150;


    public float cadaSegundos = 5;
    public bool actualizaSombrasSegundos = true;
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

        if(_miTime >= cadaSegundos){
           
            _miTime = 0;
            _actualiza = !_actualiza;
        }

        this.actualizaSombras();
         _miTime += Time.deltaTime;

    }

    void actualizaSombras(){

        if(actualizaSombrasSegundos){
            if(_miTime <= 2) return;
        }


        if(_rot <=rot_min){
            _subida = true;
        }

        if(_rot >=rot_max){
            _subida = false;
        }

        if(_actualiza){
            if(_subida) _rot += Time.deltaTime*vel;
            if(!_subida) _rot -= Time.deltaTime*vel;
                      
            transform.rotation = Quaternion.Euler(45+_rot/100,_rot,90);
        }


    }

}
