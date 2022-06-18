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
   
}
