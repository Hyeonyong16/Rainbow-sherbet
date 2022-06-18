using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefabsManager : MonoBehaviour
{
    public GameObject NULLBlock;
    public List<GameObject> ColorBlocks;        //�� �� �����յ�
    public List<GameObject> ObstacleBlocks;     //���ع� �� �����յ�
    public List<GameObject> ETCBlocks;          //��Ÿ �� �����յ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //��ġ�� ���� �������� �Ѱ���
    public GameObject GetBlockObject(string blockName)
    {
        if(blockName[0] == 'N')
        {
            if(SceneManager.GetActiveScene().name == "MapEditor")
                return NULLBlock;
            return null;
        }
        else if(blockName[0] == 'C')
        {
            int num = int.Parse(blockName[2].ToString() + blockName[3].ToString());
            return ColorBlocks[num];
        }
        else if(blockName[0] == 'O')
        {
            int num = int.Parse(blockName[2].ToString() + blockName[3].ToString());
            return ObstacleBlocks[num];
        }
        else if (blockName[0] == 'E')
        {
            int num = int.Parse(blockName[3].ToString());
            return ETCBlocks[num];
        }
        return null;
    }
}
