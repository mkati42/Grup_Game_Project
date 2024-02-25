using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    private Rigidbody2D cam;
    private Vector2     follow;
    GameObject  player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Soldier");
        cam.transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Soldier");
        if (player != null)
            cam.transform.position = player.transform.position;
    }
}
