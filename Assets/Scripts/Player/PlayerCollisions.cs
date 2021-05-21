using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;

public class PlayerCollisions : MonoBehaviour
{

    bool playerInCollision = false;
    
    [Header("Teriomorfismos")] [Tooltip("Cambiador de sizes")]

    public Dictionary<string, Dictionary<string,float>> animals = new Dictionary<string, Dictionary<string,float>>(){
        {
            "human", new Dictionary<string,float>(){
                {"mainScale", 0.5f},
                {"mainFOV", 1f},
                {"speed",4f},
                {"mass", 1.0f},
                {"jump",5f}
            }
        },
        {
            "mouse", new Dictionary<string,float>(){
                {"mainScale", 0.10f},
                {"mainFOV", 1f},
                {"speed",7f},
                {"mass", 0.5f},
                {"jump",3f}
            }
        },
        {
            "giraffe", new Dictionary<string,float>(){
                {"mainScale", 2f},
                {"mainFOV", 1f},
                {"speed",2f},
                {"mass", 2f},
                {"jump",5f}
            }
        }
    };

    bool transforming = false;
    string transformingFrom = "human";
    string transformingTo = "human";

/* 
    public float minScale = 0.10f;
    public float maxScale = 1.5f;
    public float minFOV = 10f;
    public float maxFOV = 20f;
 */

    private Vector3 scaleChange;

    public Camera mainCam;

    Rigidbody rb;
    PlayerJump pJump;
    PlayerMovements pMovs;
    GameFlowManager gm;
    


    // Start is called before the first frame update
    void Start()
    {
        scaleChange = transform.localScale;

        rb = GetComponent<Rigidbody>();
        pJump = GetComponent<PlayerJump>();
        pMovs = GetComponent<PlayerMovements>();
        gm = FindObjectOfType<GameFlowManager>();
    }



    // Update is called once per frame
    void Update()
    {
        
        if(transforming){
            //scaleChange -= scaleChange * Time.deltaTime;
            //mainCam.fieldOfView += animals[transformingTo]["minScale"]*Time.deltaTime;
            transform.localScale = scaleChange;
            transformingScale();
        }

    }

    void transformingScale(){

        //MOUSE
        if(transformingTo == "mouse"){
            if(scaleChange.x >= animals[transformingTo]["mainScale"]){
                //Debug.Log(collision.collider.name);
                scaleChange -= scaleChange * Time.deltaTime;
                mainCam.fieldOfView += animals[transformingTo]["mainFOV"]*Time.deltaTime;
                
            }else{
                transforming = false;
            }
        }

        //HUMAN
        if(transformingTo == "human"){
           

            if(scaleChange.x == animals[transformingTo]["mainScale"]) transforming = false;

            //hay que crecer
            if(transformingFrom == "mouse"){
                if(scaleChange.x <= animals[transformingTo]["mainScale"]){
                    //Debug.Log(collision.collider.name);
                    scaleChange += scaleChange * Time.deltaTime;
                    mainCam.fieldOfView -= animals[transformingTo]["mainFOV"]*Time.deltaTime;

                }else{
                    transforming = false;
                }
            }
            //MAYOR
            if(transformingFrom == "giraffe"){
                if(scaleChange.x >= animals[transformingTo]["mainScale"]){
                    //Debug.Log(collision.collider.name);
                    scaleChange -= scaleChange * Time.deltaTime;
                    mainCam.fieldOfView += animals[transformingTo]["mainFOV"]*Time.deltaTime;

                }else{
                    transforming = false;
                }
            }

        }

        //GIRAFFE
        if(transformingTo == "giraffe"){
            if(scaleChange.x <= animals[transformingTo]["mainScale"]){
                //Debug.Log(collision.collider.name);
                scaleChange += scaleChange * Time.deltaTime;
                mainCam.fieldOfView -= animals[transformingTo]["mainFOV"]*Time.deltaTime;
            }else{
                transforming = false;
            }
        }


    }


/*

    private void OnCollisionEnter(Collision collision)
    {
        //LogCollsiionEnter.text = "On Collision Enter: " + collision.collider.name;

    }



    private void OnCollisionStay(Collision collision)
    {

        Debug.Log(collision.collider.tag);

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

*/


    //TRIGGER Mas eficiente
    private void OnTriggerEnter(Collider otro)
    {
        Debug.Log(otro.tag);

        if(otro.tag == "levelComplete"){
            levelComplete();
        }

  
        transforming = true;

        if(otro.tag == "tinier"){
            transformingFrom = transformingTo;
            transformingTo = "mouse";
        }

        if(otro.tag == "human"){
            transformingFrom = transformingTo;
            transformingTo = "human";
        }
        if(otro.tag == "bigger"){
            transformingFrom = transformingTo;
            transformingTo = "giraffe";
        }
        
        rb.mass = animals[transformingTo]["mass"]; 

        pJump.jumpForce = animals[transformingTo]["jump"];
        pMovs.speed = animals[transformingTo]["speed"];


    }


    private void levelComplete(){

        Debug.Log("levelComplete from collision");

        //Fade
        gm.lvlEndFade();
     
    }



}
