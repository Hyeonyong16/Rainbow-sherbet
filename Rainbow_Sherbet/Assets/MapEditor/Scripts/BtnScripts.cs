using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnScripts : MonoBehaviour
{
    public string currentBtnBlock = "NULL";
    public MapEditManager mapEditManager;
    public Text text;

    Button btn;

    // Start is called before the first frame update
    void Awake()
    {
        btn = gameObject.GetComponent<Button>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetOnClickEvent()
    {
        btn.onClick.AddListener(SetBtnBlock);
    }

    void SetBtnBlock()
    {
        mapEditManager.selectedBlock = currentBtnBlock;
    }

}
