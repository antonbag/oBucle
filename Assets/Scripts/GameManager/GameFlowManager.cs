using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.OBUCLE.Game
{

    

    public class GameFlowManager : MonoBehaviour
    {

        [Header("Scenes")] [Tooltip("Scene to start on play")]
        public string StartScene = "StartScene";

        public bool canMove = false;

        [Header("Menu Options")] [Tooltip("Menu options")]
        public bool globalFX = true;

        GameObject inGameMenu;



        public bool GameIsEnding { get; private set; }





        void Awake() {
            
        }


        // Start is called before the first frame update
        void Start()
        {

            //START MENU
            if(StartScene == SceneManager.GetActiveScene().name){
                Debug.Log("IS START!!");
                this.canMove = false;
            }else{
                this.canMove = true;
            }


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
                    inGameMenu.transform.localScale = new Vector3(0,0,0);
                    inGameMenu.SetActive(false);
                    this.canMove = true;
                }else{
                    inGameMenu.SetActive(true);
                    inGameMenu.transform.localScale = new Vector3(1,1,1);
                    this.canMove = false;
                }
                
            }
        }


    }




}
