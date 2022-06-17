using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEditManager : MonoBehaviour
{
    public int blockSize = 1;   //���簢�� ���� �Ѻ� ����
    public Vector2 mapSize = new Vector2(10, 25);   //���� ũ��

    //������ ���� �� �θ� ������Ʈ
    public GameObject parentObject;

    //UI �Ŵ���
    public UIButtonManager uIButtonManager;

    //���� �Ŵ���
    public SaveLoadManager saveLoadManager;
    public string stageName;    //�������� ��

    //���Ǵ� ������ �������� �����س��� �ҷ����� �Ŵ���
    public PrefabsManager prefabsManager;
    //���� ���õǾ��ִ� ��ġ�� �� �̸�
    public string selectedBlock;

    public string[] mapBlocks;  //��ġ�� ���� �ڵ带 ���� �迭
    public GameObject[] BlocksArray;

    // Start is called before the first frame update
    void Start()
    {
        //������ ���� �迭 ����
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

            //�� ����
            //���ڿ� �迭�� stringSize�� ����ִ� ���ڵ带 ����
            //�׿� �´� �� �������� ����
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

        //�� ����
        //���ڿ� �迭�� stringSize�� ����ִ� ���ڵ带 ����
        //�׿� �´� �� �������� ����
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
