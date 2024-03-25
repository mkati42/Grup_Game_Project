using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioSource  gameSource;
    public AudioClip    gameMusic1;
    public AudioClip    gameMusic2;
    public AudioClip    gameMusic3;
    // Start is called before the first frame update
    void Start()
    {
        int whichMusic = Random.Range(1, 4);
        if (whichMusic == 1)
            gameSource.clip = gameMusic1;
        else if (whichMusic == 2)
            gameSource.clip = gameMusic2;
        else if (whichMusic == 3)
            gameSource.clip = gameMusic3;
        gameSource.volume = PlayerPrefs.GetFloat("game");
        gameSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        gameSource.volume = PlayerPrefs.GetFloat("game");
    }
}
