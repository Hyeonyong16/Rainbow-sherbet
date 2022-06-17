using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    string StageName;
    public Vector2 mapSize = new Vector2(11, 20); //맵의 크기

    public string[] mapBlocks;  //설치된 블럭의 코드를 담을 배열
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
