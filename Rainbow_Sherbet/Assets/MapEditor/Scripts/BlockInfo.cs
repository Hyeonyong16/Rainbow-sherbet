using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockCase
{
    NullBlock = 0,  //아무것도 X
    StartBlock,     //시작블럭
    EndBlock,       //끝 블럭
    ColorBlock,     //색 블럭
    ObstacleBlock   //장애물 블럭
}

public class BlockInfo : MonoBehaviour
{ 
    public string BlockCode;    //깔릴 블럭의 종류

    public Vector2 Pos;         //블럭 위치

    public bool isStar;         //별을 위에 놔둘것인지

    public BlockCase blockCase; //현재 블럭의 종류

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitBlock()
    {
        if(BlockCode[0] == 'N')
        {
            blockCase = BlockCase.NullBlock;
        }
        else if(BlockCode[0] == 'C')
        {
            blockCase = BlockCase.ColorBlock;
        }
        else if(BlockCode[0] == 'O')
        {
            blockCase = BlockCase.ObstacleBlock;
        }
    }
}
