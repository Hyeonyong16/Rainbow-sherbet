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
        string sceneName = "Stage"+ GameManagerUI._instance.stageNum.ToString();
        SceneManager.LoadScene(sceneName);
    }

    void LoadStageSelect()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage_select");
    }

    void LoadStage1()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage1");
    }

    void LoadStage2()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage2");
    }

    void LoadStage3()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage3");
    }

    void LoadStage4()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage4");
    }

    void LoadStage5()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage5");
    }

    void LoadStage6()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage6");
    }

    void LoadStage7()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage7");
    }


    void LoadStage8()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage8");
    }

    void LoadStage9()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage9");
    }

    void LoadStage10()
    {
        GameManagerUI._instance.stageNumStars = 0;
        SceneManager.LoadScene("Stage10");
    }
}
