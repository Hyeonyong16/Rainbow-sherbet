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




}
