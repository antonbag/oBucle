using Unity.OBUCLE.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Unity.OBUCLE.UI
{
    public class startMenu : MonoBehaviour
    {

        GameFlowManager gm;  
        float _miTime = 0;

        [Tooltip("Root GameObject of the menu used to toggle its activation")]
        public GameObject MenuRoot;

        bool _shown = false;
        public float aumentoFade = 0.01f;
        float fadeIn = 0f;

        public void GoToScene(bool show)
        {
            SceneManager.LoadScene("oBucle_lvl1");
        }


        // Start is called before the first frame update
        void Start()
        {

 
        }

        // Update is called once per frame
        void Update()
        {
         if(fadeIn>=1.0f){
                _shown=true;
            }
            if(_shown) return;

    

            Debug.Log(aumentoFade);
            _miTime += Time.deltaTime;
            
            if(_miTime >= 1){
                fadeIn+=aumentoFade;
                gameObject.GetComponentInChildren<CanvasGroup>().alpha = fadeIn;
            }

   
            
        }
        


        public void exitObucle(){
            Debug.Log("EXIT GAME");
            Application.Quit();
        }
    
    }
}
