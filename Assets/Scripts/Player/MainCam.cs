using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.OBUCLE.Game;

public class MainCam : MonoBehaviour
{

    GameFlowManager gm;  

    // Start is called before the first frame update
    public Transform cam;
    public float sensitivity;
    float headRotation = 0f;
    
    float x,y;

    public float headRotationLimit = 90f;


 
    void Start()
    {
        gm = FindObjectOfType<GameFlowManager>();

    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime * -1.0f;

        //Si se puede mover
        if(gm.canMove){

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            transform.Rotate(0f, x, 0f);

            headRotation += y;
            headRotation = Mathf.Clamp(headRotation, -headRotationLimit, headRotationLimit);
            cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);

        }else{
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }


    }
}
