using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CheckPointManager checkPointManager;  // Start is called before the first frame update
    
    
    void Start()
    {
        checkPointManager = FindObjectOfType<CheckPointManager>();
        transform.position = checkPointManager.checkPointPriority.First.Value.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        transform.position = checkPointManager.checkPointPriority.First.Value.position;
    }
}
