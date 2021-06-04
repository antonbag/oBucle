using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hagoChas : MonoBehaviour
{
    public float alfa = 1.0f; 
    public GameObject currentGameObject;  
    // Start is called before the first frame update
    void Start()
    {
        currentGameObject = gameObject;  
    }

    // Update is called once per frame
    void Update()
    {
        ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alfa);
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }
}
