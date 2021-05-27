using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;

public class PlayerJump : MonoBehaviour
{
    Rigidbody rb;
    GameFlowManager gm;  

    float _tiempoTranscurrido = 0;
    public float jumpForce;
    // Start is called before the first frame update
    
    //test trampantojo
    showTrampantojo showTrampantojo;
    void Start()
    {
        gm = FindObjectOfType<GameFlowManager>();
        rb = GetComponent<Rigidbody>();
        _tiempoTranscurrido = Time.deltaTime;

        //test trampantojo
        showTrampantojo = FindObjectOfType<showTrampantojo>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gm.canMove) return;

        _tiempoTranscurrido += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space)) {

            if(_tiempoTranscurrido >= 1){
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                _tiempoTranscurrido=0;

                Debug.Log("puedo saltar");
            }            
        }

        //TEST objeto trampantojo
        if (Input.GetKeyDown(KeyCode.T)) {
            showTrampantojo.tests=true;
        }


    }
}
