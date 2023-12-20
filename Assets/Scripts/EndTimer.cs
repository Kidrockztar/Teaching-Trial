using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTimer : MonoBehaviour
{
    private Timer timer;
    private CheckPointManager checkPointManager;
    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<Timer>();
        checkPointManager = FindObjectOfType<CheckPointManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer.StopTimer();
            other.gameObject.transform.position = checkPointManager.startLocation.position;
        }
    }
}
