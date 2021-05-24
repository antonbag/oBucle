using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;
public class PlayerMovements : MonoBehaviour
{

    Rigidbody rb;
    GameFlowManager gm;  
    //[SerializeField] private float speed;
    
    public float speed = 1.0f;
    float x;
    float z;
    float y;

    float atenuadorTiny;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameFlowManager>();
       
        atenuadorTiny = transform.localScale.y;
    }


    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        //cuando eres pequeño corres menos
        atenuadorTiny = transform.localScale.y;

        //volver al inicio si te sales de la pantallas
        y = this.transform.position.y; 
        if(y < -10){
            transform.position = new Vector3(0,0,0);
            x = 0;
        }
    }


    void FixedUpdate()
    {
        if(gm.canMove){
            //Debug.Log(atenuadorTiny);
            Vector3 moveBy = transform.right * x + transform.forward * z;
            //Debug.Log(moveBy);
            rb.MovePosition(transform.position + moveBy.normalized * speed * atenuadorTiny * Time.deltaTime);
        }
    }



}
