using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class OLDlvlCompFade : MonoBehaviour
    {
        private bool fading = false;
        CanvasGroup _group;
        // Start is called before the first frame update
        void Start()
        {
            _group = GetComponent<CanvasGroup>();
            _group.alpha = 0f;
           
        }

        // Update is called once per frame
        void Update()
        {
            _group.alpha =+ 0.1f;
            if(fading){

                Debug.Log("Fading!");
            }
        }


        public void startFade(){

            Debug.Log("startFading");
            fading = true;
        }
    }

