using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    void SceneChange()
    {
        GameManagerUI._instance.stageNumStars = 0;
        GameManagerUI._instance.stageNum++;
        string sceneName = "Stage" + GameManagerUI._instance.stageNum.ToString();
        SceneManager.LoadScene(sceneName);
    }

    public void LoadStageSelect()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage_select");
    }
    
    public void LoadStage1()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 1;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadSceneAsync("Stage1");     
    }

    public void LoadStage2()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 1;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage2");
    }

    public void LoadStage3()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 2;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage3");
    }

    public void LoadStage4()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 3;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage4");
    }

    public void LoadStage5()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 3;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage5");
    }

    public void LoadStage6()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 4;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage6");
    }

    public void LoadStage7()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 4;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage7");
    }


    public void LoadStage8()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 5;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage8");
    }

    public void LoadStage9()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 6;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage9");
    }

    public void LoadStage10()
    {
        Time.timeScale = 1;
        GameManagerUI._instance.colorLimitCount = 6;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage10");
    }
}
