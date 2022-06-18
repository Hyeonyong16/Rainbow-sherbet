using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    public GameManager gameManager;

    public PrefabsManager prefabsManager;
    public int blockSize = 1;

    //������ ���� �� �θ� ������Ʈ
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
        //���� ��ο� ����������.json ������ �ִ��� Ȯ��
        string filePath = Application.dataPath + "/" + stageName + ".json";
        Debug.Log("filePath: " + filePath);
        FileInfo fileInfo = new FileInfo(filePath);
        Debug.Log(fileInfo.Exists);
        //������ �׳� ��ȯ
        if (!fileInfo.Exists)
        {
            return;
        }

        //������ json���� �ε�
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

            //�� ����
            //���ڿ� �迭�� stringSize�� ����ִ� ���ڵ带 ����
            //�׿� �´� �� �������� ����
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
