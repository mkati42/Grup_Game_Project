using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMusic : MonoBehaviour
{
    public AudioSource  gunsVoice;
    public AudioClip[]  guns;
    public AudioSource  walking;
    public AudioClip    walkingVoice;

    private GameObject  fireObject;
    private Rigidbody2D   fireRb;
    private Fire        activeGuns;

    void Start()
    {
        fireObject = GameObject.Find("Soldier");
        fireRb = fireObject.GetComponent<Rigidbody2D>();
        activeGuns = fireRb.GetComponent<Fire>();
        gunsVoice.clip = guns[activeGuns.getGunsIndex()];
        walking.clip = walkingVoice;
    }

    void Update()
    {

    }

    public void playGunsVoice()
    {
        gunsVoice.clip = guns[activeGuns.getGunsIndex()];
        gunsVoice.Play();
    }

    public void playWalkingVoice()
    {
        walking.Play();
    }

    public void stopSelectedVoice(string which)
    {
        if (which == "walk")
            walking.Stop();
        else if (which == "fire")
            gunsVoice.Stop();
    }
}
