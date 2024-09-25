using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAlien : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //handle movement here
        transform.Translate (Time.deltaTime * Input.GetAxis("Horizontal") * 10.0f,
                        Time.deltaTime * Input.GetAxis("Vertical") * 10.0f,
                        0.0f);
        //handle rotation here
        transform.Rotate(0, 0, Time.deltaTime * 180.0f);
        //handle scaling here
        transform.localScale += new Vector3(Time.deltaTime*0.1f, Time.deltaTime*0.1f, 0);
    }
}
