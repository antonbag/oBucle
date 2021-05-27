using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Unity.OBUCLE.Game
{
    public class inGameMenu : MonoBehaviour
    {
       [Tooltip("Toggle FX")]
        public Toggle FxToggle;        
        
        GameFlowManager gm;  
        globalFX gFX;

        // Start is called before the first frame update
        void Start()
        {
            gm = FindObjectOfType<GameFlowManager>();
            gFX = FindObjectOfType<globalFX>();

           
            //TOGGLES
            FxToggle.isOn = gm.globalFX;
            FxToggle.onValueChanged.AddListener(OnFXChanged);


        } 

        // Update is called once per frame
        void Update()
        {


        }


        void OnFXChanged(bool newValue)
        {
            //globalFX.
            gFX.intercambiaFx();
            gm.globalFX = newValue;
            //Debug.Log(newValue);
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
