using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingUI : MonoBehaviour //환경설정 UI ON/OFF
{
    public GameObject SettingScreen;
    // Start is called before the first frame update
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

    public void ToStageSelect()
    {
        SceneManager.LoadScene(1);
    }

}
