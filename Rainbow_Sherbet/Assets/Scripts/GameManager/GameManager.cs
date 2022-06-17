using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    string StageName;
    public Vector2 mapSize = new Vector2(11, 20); //���� ũ��

    public string[] mapBlocks;  //��ġ�� ���� �ڵ带 ���� �迭
    public GameObject[] BlocksArray;

    public MapLoader mapLoader;

    // Start is called before the first frame update
    void Start()
    {
        int stringSize = (int)mapSize.x * (int)mapSize.y;
        mapBlocks = new string[stringSize];
        BlocksArray = new GameObject[stringSize];

        mapLoader.InitStage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStageName(string input)
    {
        StageName = input;
    }
}
