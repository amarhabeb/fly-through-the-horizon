using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactarController : MonoBehaviour
{
    public float speed = 10f;
    public producingManager PM;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HMovment = Input.GetAxis("Horizontal") * speed/2;
        float VMovment = Input.GetAxis("Vertical") * speed/2;
        transform.Translate(new Vector3(HMovment, VMovment, speed*3)* Time.deltaTime);
        if ( transform.position.z > 10*i)
        {
            PM.triggerEntered();
            i++;
        }
    }


}
