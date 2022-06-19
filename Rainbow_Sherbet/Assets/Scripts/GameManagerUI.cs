using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    public static GameManagerUI _instance;

    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public int stageNum = 0;// 몇 스테이지를 알려주는 변수
    //별 관련 변수추가
    public int stageNumStars = 0; // 스테이지별 총 별개수 - MAX : 3
    public int totalNumStars = 0; // 스테이지 1에서 스테이지  10까지 총 별개수 - MAX :30
    public int colorLimitCount = 0;// 스테이지별 색상제한 변수

    public int Stage1_Star_EndNum = 0;
    public int Stage1_Star_ClearNum = 0;

    public int Stage2_Star_EndNum = 0;
    public int Stage2_Star_ClearNum = 0;

    public int Stage3_Star_EndNum = 0;
    public int Stage3_Star_ClearNum = 0;

    public int Stage4_Star_EndNum = 0;
    public int Stage4_Star_ClearNum = 0;

    public int Stage5_Star_EndNum = 0;
    public int Stage5_Star_ClearNum = 0;

    public int Stage6_Star_EndNum = 0;
    public int Stage6_Star_ClearNum = 0;

    public int Stage7_Star_EndNum = 0;
    public int Stage7_Star_ClearNum = 0;

    public int Stage8_Star_EndNum = 0;
    public int Stage8_Star_ClearNum = 0;

    public int Stage9_Star_EndNum = 0;
    public int Stage9_Star_ClearNum = 0;

    public int Stage10_Star_EndNum = 0;
    public int Stage10_Star_ClearNum = 0;

}
