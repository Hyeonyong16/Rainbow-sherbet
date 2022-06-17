using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEditManager : MonoBehaviour
{
    public int blockSize = 1;   //정사각형 블럭의 한변 길이
    public Vector2 mapSize = new Vector2(10, 25);   //맵의 크기

    //생성된 블럭이 들어갈 부모 오브젝트
    public GameObject parentObject;

    //UI 매니저
    public UIButtonManager uIButtonManager;

    //저장 매니저
    public SaveLoadManager saveLoadManager;
    public string stageName;    //스테이지 명

    //사용되는 블럭들의 프리팹을 저장해놓고 불러오는 매니져
    public PrefabsManager prefabsManager;
    //현재 선택되어있는 설치할 블럭 이름
    public string selectedBlock;

    public string[] mapBlocks;  //설치된 블럭의 코드를 담을 배열
    public GameObject[] BlocksArray;

    // Start is called before the first frame update
    void Start()
    {
        //블럭들을 담을 배열 선언
        int stringSize = (int)mapSize.x * (int)mapSize.y;
        mapBlocks = new string[stringSize];
        BlocksArray = new GameObject[stringSize];
        InitMap();

        selectedBlock = "NULL";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBlock()
    {
        if (parentObject.transform.childCount != 0) return;
        for(int i = 0; i < mapBlocks.Length; i++)
        {
            int x = (i % (int)mapSize.x);
            int y = (i / (int)mapSize.x);
            Vector3 pos = new Vector3(x * blockSize, 0, y * blockSize);

            //블럭 생성
            //문자열 배열인 stringSize에 들어있는 블럭코드를 보고
            //그에 맞는 블럭 프리팹을 들고옴
            GameObject go = Instantiate(
                prefabsManager.GetBlockObject(mapBlocks[i]),
                Vector3.zero,
                Quaternion.identity
                ) as GameObject;
            go.GetComponent<BlockInfo>().SetBlockPos(new Vector2(pos.x, pos.z));
            go.transform.parent = parentObject.transform;
            BlocksArray[i] = go;
        }
    }

    public void CreateBlock(int num)
    {
        int x = (num % (int)mapSize.x);
        int y = (num / (int)mapSize.x);
        Vector3 pos = new Vector3(x * blockSize, 0, y * blockSize);

        //블럭 생성
        //문자열 배열인 stringSize에 들어있는 블럭코드를 보고
        //그에 맞는 블럭 프리팹을 들고옴
        GameObject go = Instantiate(
            prefabsManager.GetBlockObject(mapBlocks[num]),
            Vector3.zero,
            Quaternion.identity
            ) as GameObject;
        go.GetComponent<BlockInfo>().SetBlockPos(new Vector2(pos.x, pos.z));
        go.transform.parent = parentObject.transform;
        BlocksArray[num] = go;
    }

    public void InitMap()
    {
        for(int i = 0; i < mapBlocks.Length; i++)
        {
            mapBlocks[i] = "NULL";
        }
    }
    
    public void InitMap(MapData data)
    {
        stageName = data.stageName;
        mapBlocks = (string[])data.mapBlocks.Clone();

        foreach(var i in BlocksArray)
        {
            Destroy(i);
        }

        CreateBlock();
    }
}
