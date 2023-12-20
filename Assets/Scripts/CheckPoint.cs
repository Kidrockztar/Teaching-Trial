using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckPointManager checkPointManager;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        checkPointManager = FindObjectOfType<CheckPointManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            checkPointManager.AddCheckPoint(transform);
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    public void ResetColor()
    {
        cube.GetComponent<Renderer>().material.color = Color.white;
    }
}
