using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
    }
    public void StopTimer()
    {
        if (TimerCount.stop)
        {
            TimerCount.stop = false;
        }
        else
        {
            TimerCount.stop = true;
        }
    }
}

