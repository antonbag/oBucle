using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sferaMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sun;

    Rigidbody m_Rigidbody;

    public Vector3 fuerza;

    float y;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        //Apply a force to this Rigidbody in direction of this GameObjects up axis
        m_Rigidbody.AddForce(this.fuerza);

    }



    // Update is called once per frame
    void Update()
    {


        //volver al inicio si te sales de la pantallas
        y = this.transform.position.y; 
        if(y < -10){
            transform.position = new Vector3(0,4,0);
        }




        //this.transform.position = new Vector3(Mathf.Sin(Time.time), 1.0f, 2.28f);

        fuerza = new Vector3(Mathf.Sin(Time.time), 1.0f, 2.28f);

        //MUEVO EL SOL
        //sun.transform.rotation = Quaternion.Euler((Mathf.Sin(Time.time)*20)+10,0,0);

    }
}
