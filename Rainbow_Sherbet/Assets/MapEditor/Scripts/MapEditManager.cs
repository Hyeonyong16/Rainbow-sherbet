using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEditManager : MonoBehaviour
{
    public int blockSize = 1;   //정사각형 블럭의 한변 길이
    public Vector2 mapSize = new Vector2(10, 25);   //맵의 크기

    public GameObject parentObject;
    public PrefabsManager prefabsManager;

    public string[] mapBlocks;  //설치된 블럭의 코드를 담을 배열

    // Start is called before the first frame update
    void Start()
    {
        //블럭들을 담을 배열 선언
        int stringSize = (int)mapSize.x * (int)mapSize.y;
        mapBlocks = new string[stringSize];
        InitMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBlock()
    {
        for(int i = 0; i < mapBlocks.Length; i++)
        {
            int x = (i % 10);
            int y = (i / 10);
            Vector3 pos = new Vector3(x * blockSize, 0, y * blockSize);

            //블럭 생성
            //문자열 배열인 stringSize에 들어있는 블럭코드를 보고
            //그에 맞는 블럭 프리팹을 들고옴
            GameObject go = Instantiate(
                prefabsManager.GetBlockObject(mapBlocks[i]),
                pos,
                Quaternion.identity
                ) as GameObject;
            go.transform.parent = parentObject.transform;
        }
    }

    public void InitMap()
    {
        for(int i = 0; i < mapBlocks.Length; i++)
        {
            mapBlocks[i] = "NULL";
        }
    }
}
