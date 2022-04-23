using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadsProducer : MonoBehaviour
{
    public List<GameObject> roads;//a list of the roads to generate the endless road
    float offset = 10f;//the offset between every two roads based on the length of the road
    // Start is called before the first frame update
    void Start()
    {
    }


    public void moveRoads()
    {
        // this function extraxts  the first road in the list and add another road to the end of the list
        GameObject tempRoad = roads[0];
        roads.Remove(tempRoad);
        Vector3 newPosition = new Vector3(0, 0, roads[roads.Count - 1].transform.position.z + offset);
        tempRoad.transform.position = newPosition;
        roads.Add(tempRoad);
    }
}
