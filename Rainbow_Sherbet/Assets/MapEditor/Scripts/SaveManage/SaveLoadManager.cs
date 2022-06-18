using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class MapData
{
    public string stageName;    //�������� ��
    public string[] mapBlocks;  //�������� �� �迭
    //public Vector2[] starPos;   //���� ���� ��ġ �迭
}

public class SaveLoadManager : MonoBehaviour
{
    public MapEditManager mapEditManager;

    //�� ������
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
        //�����Ͱ� ������ �׳� ��ȯ - �����߰� �ؾ���
        if (mapData == null) return;

        SetMapData();

        //�������� json���� ����
        string jsonStr = JsonUtility.ToJson(mapData);
        Debug.Log(jsonStr);

        //���� ��ο� ����������.json �̸����� ����
        File.WriteAllText(Application.dataPath + "/" + mapData.stageName + ".json", jsonStr);
    }

    public void LoadMapDataToJson(string stageName)
    {
        //���� ��ο� ����������.json ������ �ִ��� Ȯ��
        string filePath = Application.dataPath + "/" + stageName + ".json";
        Debug.Log("filePath: " + filePath);
        FileInfo fileInfo = new FileInfo(filePath);
        Debug.Log(fileInfo.Exists);
        //������ �׳� ��ȯ
        if (!fileInfo.Exists) {
            mapEditManager.uIButtonManager.loadErrorPart.SetActive(true);
            return;
        }

        //������ json���� �ε�
        string jsonStr = File.ReadAllText(filePath);
        mapData = JsonUtility.FromJson<MapData>(jsonStr);

        mapEditManager.InitMap(mapData);
    }

}
