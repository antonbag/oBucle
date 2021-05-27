using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tinierLight : MonoBehaviour
{
    float x = 0.0f;
    float MaxAngleDeflection = 30.0f;
    float SpeedOfPendulum = 1.0f;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*         x = Mathf.Sin(Time.time)*0.5f;
        x = x - 3.1f;
        Debug.Log(Time.deltaTime);

        transform.Rotate(0f, x, 0f); */
        time += Time.deltaTime;
        float angle = MaxAngleDeflection * Mathf.Sin( time * SpeedOfPendulum);
        transform.Rotate(0f, angle, 0f);
        //transform.Rotate = Quaternion.Euler(0,angle,0);
    }
}
