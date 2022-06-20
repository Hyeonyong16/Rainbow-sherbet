using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine;

[System.Serializable]
public class UIStarData
{
    public int[] starEndNums;
    public int[] starClearNums;
}

public class GameManagerJsonParser : MonoBehaviour
{
    GameManagerUI gameManagerUI;

    public UIStarData starData;

    // Start is called before the first frame update
    void Start()
    {
        if(gameManagerUI == null)
            gameManagerUI = gameObject.GetComponent<GameManagerUI>();

        if(SceneManager.GetActiveScene().name == "Title")
        {
            LoadStarDataToJson();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void SetStarData()
    {
        int[] starEndNumsArr = new int[10];
        int[] starClearNumsArr = new int[10];

        for (int i = 1; i < 11; i++) {
            string tempEndNum = "Stage" + i + "_Star_EndNum";
            string tempClearNum = "Stage" + i + "_Star_ClearNum";

            var result = gameManagerUI.GetType().GetField(tempEndNum).GetValue(gameManagerUI);
            starEndNumsArr[i - 1] = (int)result;

            result = gameManagerUI.GetType().GetField(tempClearNum).GetValue(gameManagerUI);
            starClearNumsArr[i - 1] = (int)result;
        }

        starData.starEndNums = (int[])starEndNumsArr.Clone();
        starData.starClearNums = (int[])starClearNumsArr.Clone();
    }

    void LoadStarData()
    {
        for (int i = 1; i < 11; i++)
        {
            string tempEndNum = "Stage" + i + "_Star_EndNum";
            string tempClearNum = "Stage" + i + "_Star_ClearNum";

            var result = gameManagerUI.GetType().GetField(tempEndNum);
            result.SetValue(gameManagerUI, starData.starEndNums[i - 1]);

            result = gameManagerUI.GetType().GetField(tempClearNum);
            result.SetValue(gameManagerUI, starData.starClearNums[i - 1]);
        }
    }

    public void SaveStarDataToJson()
    {
        Debug.Log("S");
        if (starData == null) return;

        SetStarData();

        //맵정보를 json으로 변경
        string jsonStr = JsonUtility.ToJson(starData);
        Debug.Log(jsonStr);

        //파일 경로에 스테이지명.json 이름으로 저장
        File.WriteAllText(Application.dataPath + "/UIStarData.json", jsonStr);
    }

    public void LoadStarDataToJson()
    {
        //파일 경로에 스테이지명.json 파일이 있는지 확인
        string filePath = Application.dataPath + "/UIStarData.json";
        FileInfo fileInfo = new FileInfo(filePath);
        Debug.Log(fileInfo.Exists);
        //없으면 그냥 반환
        if (!fileInfo.Exists)
        {
            return;
        }

        //있으면 json파일 로드
        string jsonStr = File.ReadAllText(filePath);
        starData = JsonUtility.FromJson<UIStarData>(jsonStr);

        LoadStarData();
    }

}
