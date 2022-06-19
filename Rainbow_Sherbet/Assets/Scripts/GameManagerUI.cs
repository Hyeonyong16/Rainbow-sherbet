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

    public int stageNum = 0;// �� ���������� �˷��ִ� ����
    //�� ���� �����߰�
    public int stageNumStars = 0; // ���������� �� ������ - MAX : 3
    public int totalNumStars = 0; // �������� 1���� ��������  10���� �� ������ - MAX :30
    public int colorLimitCount = 0;// ���������� �������� ����

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
