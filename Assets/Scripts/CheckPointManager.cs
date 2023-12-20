using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{

    public Transform startLocation;

    public LinkedList<Transform> checkPointPriority = new LinkedList<Transform>();
    void Awake()
    {
        checkPointPriority.AddFirst(startLocation);
    }

    public void AddCheckPoint(Transform checkPoint)
    {
        checkPointPriority.AddFirst(checkPoint);
    }

     public void ResetCheckPoints()
    {
        checkPointPriority.AddFirst(startLocation);
    }
}
