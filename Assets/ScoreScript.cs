using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int score;
    Text text;
    public AudioSource playerAudio;
    

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
        playerAudio = GetComponent<AudioSource>();
    }

    public void increment(int value)
    {
        score += value;
    }

    // Update is called once per frame
    void Update()
    {
        if (score % 10 == 0)
        {
            playerAudio.Play();
        }
        text.text = "Score: " + score;
    }
}
