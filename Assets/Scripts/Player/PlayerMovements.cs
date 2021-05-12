using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;
public class PlayerMovements : MonoBehaviour
{

    Rigidbody rb;
    GameFlowManager gm;  
    //[SerializeField] private float speed;
    
    public float speed = 1;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameFlowManager>();

        

    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if(gm.canMove){
            Vector3 moveBy = transform.right * x + transform.forward * z;
            rb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);
        }

   
    }
}
