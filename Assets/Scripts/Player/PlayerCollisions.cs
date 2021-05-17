using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollisions : MonoBehaviour
{

    bool playerInCollision = false;
    
    public float minScale = 0.10f;
    public float maxScale = 1.5f;
    public float minFOV = 10f;
    public float maxFOV = 20f;
    private Vector3 scaleChange;

    public Camera mainCam;




    // Start is called before the first frame update
    void Start()
    {
        scaleChange = transform.localScale;


    }



    // Update is called once per frame
    void Update()
    {
        transform.localScale = scaleChange;
    }



    private void OnCollisionEnter(Collision collision)
    {
        //LogCollsiionEnter.text = "On Collision Enter: " + collision.collider.name;

    }



    private void OnCollisionStay(Collision collision)
    {



        if(collision.collider.tag == "tinier"){


            Debug.Log(collision.collider.tag);

            if(scaleChange.x >= minScale){
                //Debug.Log(collision.collider.name);
                scaleChange -= scaleChange * Time.deltaTime;

                mainCam.fieldOfView += minFOV*Time.deltaTime;
            }

        }



        if(collision.collider.tag == "bigger"){

            if(scaleChange.x <= maxScale){
                //Debug.Log(collision.collider.name);
                scaleChange += scaleChange * Time.deltaTime;

                if(mainCam.fieldOfView >= maxFOV) mainCam.fieldOfView -= 1.0f*Time.deltaTime;
                
            }

        }

        //LogCollisionStay.text = "On Collision stay: " + collision.collider.name;
    
    }

    private void OnCollisionExit(Collision collision)
    {
        //LogCollisionExit.text = "On Collision exit: " + collision.collider.name;
    }   



}
