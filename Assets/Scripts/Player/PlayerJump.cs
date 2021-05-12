using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;

public class PlayerJump : MonoBehaviour
{
    Rigidbody rb;
    GameFlowManager gm;  

    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameFlowManager>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!gm.canMove) return;

        

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
