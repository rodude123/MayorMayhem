using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Threading;

public class TimerScript : MonoBehaviour
{
    public int time = 0;
    public PlayerHealth health;
    Text text;
    private int nextUpdate = 1;

    void Awake()
    {
        text = GetComponent<Text>();
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        bool dead = health.isDead;
        if (!dead)
        {
           
            text.text = "timer: " + time;
        }
        else
        {
            StopCoroutine("LooseTime");
        }


    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time++;
        }
    }
}
