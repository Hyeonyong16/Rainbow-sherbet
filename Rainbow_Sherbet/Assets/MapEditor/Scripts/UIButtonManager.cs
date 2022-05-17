using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIButtonManager : MonoBehaviour
{
    public MapEditManager mapEditManager;
    public PrefabsManager prefabsManager;

    string currentActiveMode;   //COLOR, OBSTACLE, ETC

    //public GameObject btnParentObject;  //버튼들을 담고있는 부모오브젝트
    public Button[] btns;   //블럭 버튼들

    public GameObject blockErrorPart;   //저장버튼시 에러UI
    public GameObject savePart;         //저장UI
    public GameObject loadErrorPart;    //로드시 에러UI
    public GameObject loadPart;         //로드UI

    // Start is called before the first frame update
    void Start()
    {
        if (!prefabsManager) prefabsManager = mapEditManager.prefabsManager;

        currentActiveMode = "COLOR";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeActiveMode(string mode)
    {
        currentActiveMode = mode;

        if(mode == "COLOR")
        {
            for (int i = 0; i < btns.Length; i++)
            {
                if (i < prefabsManager.ColorBlocks.Count)
                {
                    btns[i].gameObject.SetActive(true);
                    
                    string temp = "CB" + "0" + i.ToString();
                    btns[i].gameObject.GetComponent<BtnScripts>().currentBtnBlock = temp;
                    btns[i].gameObject.GetComponent<BtnScripts>().SetOnClickEvent();
                }

                else btns[i].gameObject.SetActive(false);
            }
            return;
        }
        if (mode == "OBSTACLE")
        {
            for (int i = 0; i < btns.Length; i++)
            {
                if (i < prefabsManager.ObstacleBlocks.Count)
                {
                    btns[i].gameObject.SetActive(true);

                    string temp = "OB" + "0" + i.ToString();
                    btns[i].gameObject.GetComponent<BtnScripts>().currentBtnBlock = temp;
                    btns[i].gameObject.GetComponent<BtnScripts>().SetOnClickEvent();
                }

                else btns[i].gameObject.SetActive(false);
            }
            return;
        }
        if (mode == "ETC")
        {
            for (int i = 0; i < btns.Length; i++)
            {
                if (i < prefabsManager.ETCBlocks.Count)
                {
                    btns[i].gameObject.SetActive(true);

                    string temp = "ETC" + i.ToString();
                    btns[i].gameObject.GetComponent<BtnScripts>().currentBtnBlock = temp;
                    btns[i].gameObject.GetComponent<BtnScripts>().SetOnClickEvent();
                }

                else btns[i].gameObject.SetActive(false);
            }
            return;
        }
    }

    //메인화면에서 Save버튼
    public void SaveMap()
    {
        bool isStartExist = false;
        bool isEndExist = false;

        //시작이랑 끝점이 있는지 체크
        for (int i = 0; i < mapEditManager.BlocksArray.Length; i++)
        {
            if (isStartExist && isEndExist) break;
            if (mapEditManager.mapBlocks[i] == "ETC0") isStartExist = true;
            if (mapEditManager.mapBlocks[i] == "ETC1") isEndExist = true;
        }

        //하나라도 없으면 에러창 띄우고 반환
        if (isStartExist == false || isEndExist == false)
        {
            blockErrorPart.SetActive(true);
            return;
        }

        //둘다 있으면 저장하는UI 띄움
        savePart.SetActive(true);
    }

    //세이브 UI 안에서 Save버튼
    public void SaveDataButton(TMP_InputField inputField)
    {
        mapEditManager.stageName = inputField.text;
        mapEditManager.saveLoadManager.SaveMapDataToJson();
    }

    //메인화면에서 Load버튼
    public void LoadMap()
    {
        loadPart.SetActive(true);
    }

    //로드 UI 안에서 Load버튼
    public void LoadDataButton(TMP_InputField inputField)
    {
        mapEditManager.stageName = inputField.text;
        mapEditManager.saveLoadManager.LoadMapDataToJson(mapEditManager.stageName);
    }
}
