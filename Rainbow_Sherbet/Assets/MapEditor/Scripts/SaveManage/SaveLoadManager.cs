using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class MapData
{
    public string stageName;    //스테이지 명
    public string[] mapBlocks;  //스테이지 블럭 배열
    //public Vector2[] starPos;   //별이 있을 위치 배열
}

public class SaveLoadManager : MonoBehaviour
{
    public MapEditManager mapEditManager;

    //맵 데이터
    public MapData mapData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetMapData()
    {
        mapData.stageName = mapEditManager.stageName;
        mapData.mapBlocks = (string[])mapEditManager.mapBlocks.Clone();
    }

    public void SaveMapDataToJson()
    {
        //데이터가 없으면 그냥 반환 - 에러뜨게 해야함
        if (mapData == null) return;

        SetMapData();

        //맵정보를 json으로 변경
        string jsonStr = JsonUtility.ToJson(mapData);
        Debug.Log(jsonStr);

        //파일 경로에 스테이지명.json 이름으로 저장
        File.WriteAllText(Application.dataPath + "/" + mapData.stageName + ".json", jsonStr);
    }

    public void LoadMapDataToJson(string stageName)
    {
        //파일 경로에 스테이지명.json 파일이 있는지 확인
        string filePath = Application.dataPath + "/" + stageName + ".json";
        Debug.Log("filePath: " + filePath);
        FileInfo fileInfo = new FileInfo(filePath);
        Debug.Log(fileInfo.Exists);
        //없으면 그냥 반환
        if (!fileInfo.Exists) {
            mapEditManager.uIButtonManager.loadErrorPart.SetActive(true);
            return;
        }

        //있으면 json파일 로드
        string jsonStr = File.ReadAllText(filePath);
        mapData = JsonUtility.FromJson<MapData>(jsonStr);

        mapEditManager.InitMap(mapData);
    }
}
