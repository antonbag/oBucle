using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2SoundCollision : MonoBehaviour
{

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter!");
        if (other.tag == "Player" && !audioSource.isPlaying)
        {

            Debug.Log(other.tag);
            audioSource.Play();
        }
    }
}
