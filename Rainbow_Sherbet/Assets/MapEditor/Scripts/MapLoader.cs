using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public GameManager gameManager;

    public PrefabsManager prefabsManager;
    public int blockSize = 1;

    //생성된 블럭이 들어갈 부모 오브젝트
    public GameObject parentObject;

    public MapData mapData;
    public string stageFileName;

    
    // Start is called before the first frame update
    void Start()
    {
        parentObject = new GameObject("Blocks");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InitStage()
    {
        LoadMapDataToJsonInPlay(stageFileName);

        gameManager.SetStageName(mapData.stageName);
        gameManager.mapBlocks = (string[])mapData.mapBlocks.Clone();

        CreateBlock();
    }

    void LoadMapDataToJsonInPlay(string stageName)
    {
        //파일 경로에 스테이지명.json 파일이 있는지 확인
        string filePath = Application.dataPath + "/" + stageName + ".json";
        Debug.Log("filePath: " + filePath);
        FileInfo fileInfo = new FileInfo(filePath);
        Debug.Log(fileInfo.Exists);
        //없으면 그냥 반환
        if (!fileInfo.Exists)
        {
            return;
        }

        //있으면 json파일 로드
        string jsonStr = File.ReadAllText(filePath);
        mapData = JsonUtility.FromJson<MapData>(jsonStr);
    }

    void CreateBlock()
    {
        if (parentObject.transform.childCount != 0) return;
        for (int i = 0; i < gameManager.mapBlocks.Length; i++)
        {
            int x = (i % (int)gameManager.mapSize.x);
            int y = (i / (int)gameManager.mapSize.x);
            Vector3 pos = new Vector3(x * blockSize, 0, y * blockSize);

            //블럭 생성
            //문자열 배열인 stringSize에 들어있는 블럭코드를 보고
            //그에 맞는 블럭 프리팹을 들고옴
            if (prefabsManager.GetBlockObject(gameManager.mapBlocks[i]) != null)
            {
                GameObject go = Instantiate(
                    prefabsManager.GetBlockObject(gameManager.mapBlocks[i]),
                    Vector3.zero,
                    Quaternion.identity
                    ) as GameObject;
                go.gameObject.tag = "Blocks";
                go.GetComponent<BlockInfo>().SetBlockPos(new Vector2(pos.x, pos.z));
                go.transform.parent = parentObject.transform;
                gameManager.BlocksArray[i] = go;
            }
        }
    }
}
