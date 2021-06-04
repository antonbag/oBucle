using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//DETECCION DE TRAMPANTOJO

public class showTrampantojo : MonoBehaviour
{
    public GameObject objectTrampantojo;
    bool _vista = false;
    bool _position = false;
    bool _completado = false;

    float _miTime = 0;

    public bool tests = false;

    GameObject ojo;
float angel;

    // Start is called before the first frame update
    void Start()
    {
        objectTrampantojo.SetActive(false);

        ojo = GameObject.Find("OJO");
    }

    // Update is called once per frame
    void Update()
    {



        if(_completado){
            //this.GetComponent<cameraShake>().trauma += 0.01f;

             _miTime += Time.deltaTime;
                if(_miTime >= 8){
                    _miTime = 0;
                    ojo.transform.position = new Vector3(ojo.transform.position.x,ojo.transform.position.y,ojo.transform.position.z-40);
                    ojo.GetComponent<Rigidbody>().useGravity = true;
                }


            return;
        }

        checkVista();

        if(_position && _vista || tests){

            _miTime += Time.deltaTime;

                if(_miTime >= 3){
                
                    _miTime = 0;
                    objectTrampantojo.SetActive(true);
                    objectTrampantojo.GetComponent<Rigidbody>().useGravity = true;


                    _completado = true;

                    //TERREMOTO!
                    this.GetComponent<cameraShake>().camShakeAcive = true;
                    //this.GetComponent<cameraShake>().traumaDecay = 0.0f;

                }


        }

    }   

    private void OnTriggerEnter(Collider otro)
    {
        Debug.Log(otro.name);

        if(otro.name == "trigger_trampantojo"){
            _position = true;
        }

    }

    void OnTriggerExit(Collider otro) {
        if(otro.name == "trigger_trampantojo"){
            _position = false;
        }
    }

    void checkVista(){

        if(!_position) return;

            angel = Vector3.Angle(this.transform.forward, objectTrampantojo.transform.position-transform.position);
            Debug.Log(angel);
            if (Mathf.Abs(angel) > 10 ){
               _vista = true;
            }else{
                _vista = false;
            }
                
        
    }


}
