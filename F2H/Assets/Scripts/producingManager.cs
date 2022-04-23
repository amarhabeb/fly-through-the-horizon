using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class producingManager : MonoBehaviour

{
    RoadsProducer RP;
    // Start is called before the first frame update
    void Start()
    {
        RP = GetComponent<RoadsProducer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerEntered()
    {
        RP.moveRoads();
    }
}
