using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : Interactable
{

    public SpriteRenderer receivedItemSprite;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("interact") && playerInRange)
        {

        }
    }
}
