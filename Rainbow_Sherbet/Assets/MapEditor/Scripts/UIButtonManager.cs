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

    //public GameObject btnParentObject;  //��ư���� ����ִ� �θ������Ʈ
    public Button[] btns;   //�� ��ư��

    public GameObject blockErrorPart;   //�����ư�� ����UI
    public GameObject savePart;         //����UI
    public GameObject loadErrorPart;    //�ε�� ����UI
    public GameObject loadPart;         //�ε�UI

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
                    switch(i)
                    {
                        case 0:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "RED";
                            break;
                        case 1:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "ORANGE";
                            break;
                        case 2:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "YELLOW";
                            break;
                        case 3:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "GREEN";
                            break;
                        case 4:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "BLUE";
                            break;
                        case 5:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "NAVY";
                            break;
                        case 6:
                            btns[i].gameObject.GetComponent<BtnScripts>().text.text = "PURPLE";
                            break;
                    }
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
                    btns[i].gameObject.GetComponent<BtnScripts>().text.text = temp;
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
                    btns[i].gameObject.GetComponent<BtnScripts>().text.text = temp;
                    btns[i].gameObject.GetComponent<BtnScripts>().SetOnClickEvent();
                }

                else btns[i].gameObject.SetActive(false);
            }
            return;
        }
    }

    //����ȭ�鿡�� Save��ư
    public void SaveMap()
    {
        bool isStartExist = false;
        bool isEndExist = false;

        //�����̶� ������ �ִ��� üũ
        for (int i = 0; i < mapEditManager.BlocksArray.Length; i++)
        {
            if (isStartExist && isEndExist) break;
            if (mapEditManager.mapBlocks[i] == "ETC0") isStartExist = true;
            if (mapEditManager.mapBlocks[i] == "ETC1") isEndExist = true;
        }

        //�ϳ��� ������ ����â ���� ��ȯ
        if (isStartExist == false || isEndExist == false)
        {
            blockErrorPart.SetActive(true);
            return;
        }

        //�Ѵ� ������ �����ϴ�UI ���
        savePart.SetActive(true);
    }

    //���̺� UI �ȿ��� Save��ư
    public void SaveDataButton(TMP_InputField inputField)
    {
        mapEditManager.stageName = inputField.text;
        mapEditManager.saveLoadManager.SaveMapDataToJson();
    }

    //����ȭ�鿡�� Load��ư
    public void LoadMap()
    {
        loadPart.SetActive(true);
    }

    //�ε� UI �ȿ��� Load��ư
    public void LoadDataButton(TMP_InputField inputField)
    {
        mapEditManager.stageName = inputField.text;
        mapEditManager.saveLoadManager.LoadMapDataToJson(mapEditManager.stageName);
    }
}
