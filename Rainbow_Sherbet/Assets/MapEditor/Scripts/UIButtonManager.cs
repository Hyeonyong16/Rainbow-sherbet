using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManager : MonoBehaviour
{
    public MapEditManager mapEditManager;
    public PrefabsManager prefabsManager;

    string currentActiveMode;   //COLOR, OBSTACLE, ETC

    public GameObject btnParentObject;  //버튼들을 담고있는 부모오브젝트
    
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
    }
}
