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
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage_select");
    }
    
    public void LoadStage1()
    {
        GameManagerUI._instance.colorLimitCount = 2;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage1");
    }

    public void LoadStage2()
    {
        GameManagerUI._instance.colorLimitCount = 2;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage2");
    }

    public void LoadStage3()
    {
        GameManagerUI._instance.colorLimitCount = 3;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage3");
    }

    public void LoadStage4()
    {
        GameManagerUI._instance.colorLimitCount = 4;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage4");
    }

    public void LoadStage5()
    {
        GameManagerUI._instance.colorLimitCount = 4;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage5");
    }

    public void LoadStage6()
    {
        GameManagerUI._instance.colorLimitCount = 5;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage6");
    }

    public void LoadStage7()
    {
        GameManagerUI._instance.colorLimitCount = 5;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage7");
    }


    public void LoadStage8()
    {
        GameManagerUI._instance.colorLimitCount = 6;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage8");
    }

    public void LoadStage9()
    {
        GameManagerUI._instance.colorLimitCount = 7;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage9");
    }

    public void LoadStage10()
    {
        GameManagerUI._instance.colorLimitCount = 7;
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage10");
    }
}
