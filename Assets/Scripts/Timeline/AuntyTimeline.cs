using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class AuntyTimeline : MonoBehaviour

{ 
    public PlayableDirector timeline;
    private bool alreadyPlayed = false;

    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.isTrigger)
        {
            timeline.Stop();
            alreadyPlayed = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (alreadyPlayed == false)
        if (other.CompareTag("Player") && other.isTrigger)
        {
            timeline.Play();
        }
        
    }
}
