using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Text pauseText;
    void Update()
    {
        Debug.Log("Update");
        transform.Translate(Time.deltaTime, 0, 0);
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    public void OnTogglePauseButton()
    {
        if (Time.timeScale == 0) //∏ÿ√Á¿÷¿∏∏È
        {
            Time.timeScale = 1f; //Ω√¿€
            pauseText.text = "Pause";
        }
        else //øÚ¡˜¿Ã∏È
        {
            Time.timeScale = 0; //∏ÿ√ﬂ±‚
            pauseText.text = "Resume";
        }
    }
}