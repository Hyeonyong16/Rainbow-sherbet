using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsManager : MonoBehaviour
{
    public GameObject NULLBlock;
    public List<GameObject> ColorBlocks;        //색 블럭 프리팹들
    public List<GameObject> ObstacleBlocks;     //방해물 블럭 프리팹들
    public List<GameObject> ETCBlocks;          //기타 블럭 프리팹들

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //설치할 블럭의 프리팹을 넘겨줌
    public GameObject GetBlockObject(string blockName)
    {
        if(blockName[0] == 'N')
        {
            return NULLBlock;
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
