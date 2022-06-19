using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimer : MonoBehaviour
{
    public GameObject stageTimer;
    public Text[] text_time;
    float ClearTime; 
    // Start is called before the first frame update
    void Start()
    {
        ClearTime = stageTimer.GetComponent<Timer>().time;
    }

    // Update is called once per frame
    void Update()
    {
        ClearTime = stageTimer.GetComponent<Timer>().time;
        text_time[0].text = ((int)ClearTime / 60 % 60).ToString() + "   :";
        text_time[1].text = ((int)ClearTime % 60).ToString();
    }
}
