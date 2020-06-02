using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    private Animator anim;

        void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            anim.SetBool("doorenter", true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            anim.SetBool("doorenter", false);
        }
    }


}