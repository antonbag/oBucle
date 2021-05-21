using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Unity.OBUCLE.Game{
    public class globalFX : MonoBehaviour
    {
     
        PostProcessVolume ppVol;

        // Start is called before the first frame update
        void Start()
        {
            ppVol = gameObject.GetComponent<PostProcessVolume>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }


        public void intercambiaFx()
        {

            //GameObject.PostProcessing.isGlobal = false;
            ppVol.enabled = !ppVol.enabled;

            //Debug.Log("Toooooooooogle!");
        }

    }
}
