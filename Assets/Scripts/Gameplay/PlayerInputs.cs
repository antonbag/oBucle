using Unity.OBUCLE.Game;
using UnityEngine;

namespace Unity.OBUCLE.Gameplay
{
    public class PlayerInputs : MonoBehaviour
    {

        [Tooltip("Sensitivity multiplier for moving the camera around")]
        public float LookSensitivity = 1f;

        [Tooltip("Additional sensitivity multiplier for WebGL")]
        public float WebglLookSensitivityMultiplier = 0.25f;

        [Tooltip("Limit to consider an input when using a trigger on a controller")]
        public float TriggerAxisThreshold = 0.4f;

        [Tooltip("Used to flip the vertical input axis")]
        public bool InvertYAxis = false;

        [Tooltip("Used to flip the horizontal input axis")]
        public bool InvertXAxis = false;

        GameFlowManager m_GameFlowManager;
        
        //PlayerCharacterController m_PlayerCharacterController;
       
        bool m_FireInputWasHeld; 




        // Start is called before the first frame update
        void Start()
        {

/* 
            DebugUtility.HandleErrorIfNullGetComponent<PlayerCharacterController, PlayerInputHandler>(
                m_PlayerCharacterController, this, gameObject);
 */


        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
