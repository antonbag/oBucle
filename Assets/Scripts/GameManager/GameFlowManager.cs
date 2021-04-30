using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.OBUCLE.Game
{

    public class GameFlowManager : MonoBehaviour
    {

        [Header("Scenes")] [Tooltip("Scene to start on play")]
        public int  StartScene = 1;

        GameObject inGameMenu;

        // Start is called before the first frame update
        void Start()
        {
            //AudioUtility.SetMasterVolume(1);
            inGameMenu = GameObject.Find("inGameMenu");
            inGameMenu.SetActive(false);
        
        }

        // Update is called once per frame
        void Update()
        {


            if (Input.GetKeyDown(KeyCode.Escape))
            {

                if (Application.isEditor)
                {
                    if(Application.isPlaying){
                        Application
                    }
                   
                }
                



                Debug.Log(inGameMenu);
                if(inGameMenu.activeSelf){
                    inGameMenu.SetActive(false);
                }else{
                    inGameMenu.SetActive(true);
                }
                
            }
        }


    }




}
