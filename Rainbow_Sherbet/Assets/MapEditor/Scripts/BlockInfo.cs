using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public Vector2 Pos = Vector2.zero;         //블럭 위치

    //public bool isStar;         //별을 위에 놔둘것인지

    public BlockCase blockCase; //현재 블럭의 종류

    //임시
    public Material mat;        //현재 블럭의 마테리얼

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

    //블럭 위치 설정
    public void SetBlockPos(Vector2 inputPos)
    {
        Pos.Set(inputPos.x, inputPos.y);
        Debug.Log(Pos.x + " : " + Pos.y);
        gameObject.transform.position = new Vector3(Pos.x, 0, Pos.y);
    }

    //맵에디터일경우 마우스를 갖다 대면 알수있게 마테리얼 변경한뒤
    //마테리얼 기존것으로 해제 하는 부분
    private void OnMouseExit()
    {
        if (SceneManager.GetActiveScene().name == "MapEditor")
        {
            Material[] tempMat = gameObject.GetComponent<MeshRenderer>().materials;
            Color tempColor = mat.color;
            tempMat[0].color = tempColor;
            gameObject.GetComponent<MeshRenderer>().materials = tempMat;
        }
    }
}
