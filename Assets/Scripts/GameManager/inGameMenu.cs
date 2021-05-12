using UnityEngine;

namespace Unity.OBUCLE.Game
{
    public class inGameMenu : MonoBehaviour
    {

        GameFlowManager gm;  

        // Start is called before the first frame update
        void Start()
        {
           gm = FindObjectOfType<GameFlowManager>();
        } 

        // Update is called once per frame
        void Update()
        {


        }

        public void exitObucle(){
            Debug.Log("EXIT GAME");

            Application.Quit();
        }


        public void exitInGameMenu(){
            Debug.Log("EXIT PANEL");
            gameObject.SetActive(false);
            gm.canMove = true;
        }
    
    }
}
