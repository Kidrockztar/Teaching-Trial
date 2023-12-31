using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsZone : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().Reset();
        }
    }
}
