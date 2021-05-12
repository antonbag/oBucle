using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.OBUCLE.Game
{

    

    public class GameFlowManager : MonoBehaviour
    {

        [Header("Scenes")] [Tooltip("Scene to start on play")]
        public string StartScene = "StartScene";

        public bool canMove = false;

        GameObject inGameMenu;

        public bool GameIsEnding { get; private set; }

        void Awake() {
            //START MENU
            if(StartScene == SceneManager.GetActiveScene().name){
                Debug.Log("IS START!!");
                canMove = false;
            }
        }


        // Start is called before the first frame update
        void Start()
        {

            


            //AudioUtility.SetMasterVolume(1);
            inGameMenu = GameObject.Find("inGameMenu");
            if(inGameMenu) inGameMenu.SetActive(false);
        
        }

        // Update is called once per frame
        void Update()
        {





            //ESC
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                //START MENU
                if(StartScene == SceneManager.GetActiveScene().name){
                    Debug.Log("IS START!! no muestro el menu");
                    return;
                }

                if (Application.isEditor)
                {
                    Debug.Log("is Editor!");
                }
                

                if(inGameMenu.activeSelf){
                    inGameMenu.SetActive(false);
                }else{
                    inGameMenu.SetActive(true);
                }
                
            }
        }


    }




}
