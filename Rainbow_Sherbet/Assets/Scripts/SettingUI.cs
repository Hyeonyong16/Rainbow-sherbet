using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour //환경설정 UI ON/OFF
{
    public GameObject SettingScreen;
    public GameObject InstructionScreen;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

   public void OnSetting()
    {
        SettingScreen.SetActive(true);        
    }

    public void OffSetting()
    {
        SettingScreen.SetActive(false);
    }

    public void OnInstructionScreen()
    {
        InstructionScreen.SetActive(true);
    }

    public void OffInstructionScreen()
    {
        InstructionScreen.SetActive(false);
    }

    public void ToStageSelect()
    {
        SceneManager.LoadScene(1);
    }



}
