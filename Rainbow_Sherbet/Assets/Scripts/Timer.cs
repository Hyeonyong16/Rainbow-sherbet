using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text[] text_time; // 시간을 표시할 text
    float time; // 시간.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text_time[0].text = ((int)time / 60 % 60).ToString()+"   :";
        text_time[1].text = ((int)time % 60).ToString();
    }
}
