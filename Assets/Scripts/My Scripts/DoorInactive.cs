using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInactive : MonoBehaviour
{

    public GameObject target;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!target.activeSelf)
            {
                target.SetActive(true);
            }
        }
    }
}