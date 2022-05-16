using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonManager : MonoBehaviour
{
    public MapEditManager mapEditManager;
    public PrefabsManager prefabsManager;

    string currentActiveMode;   //COLOR, OBSTACLE, ETC

    //public GameObject btnParentObject;  //버튼들을 담고있는 부모오브젝트
    public Button[] btns;   //블럭 버튼들
    
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
}
