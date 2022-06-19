using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Data
{
    public int Stage1Star;
    public int Stage2Star;
    public int Stage3Star;
    public int Stage4Star;
    public int Stage5Star;
    public int Stage6Star;
    public int Stage7Star;
    public int Stage8Star;
    public int Stage9Star;
    public int Stage10Star;


    public void printData()
    {
        Debug.Log("스테이지1별개수 : " + Stage1Star);
    }
}


public class SaveData : MonoBehaviour //환경설정 UI ON/OFF
{
    void Start()
    {
        Data data = new Data();
        data.Stage1Star = GameManagerUI._instance.Stage1_Star_ClearNum;
        data.Stage2Star = GameManagerUI._instance.Stage2_Star_ClearNum;
        data.Stage3Star = GameManagerUI._instance.Stage3_Star_ClearNum;
        data.Stage4Star = GameManagerUI._instance.Stage4_Star_ClearNum;
        data.Stage5Star = GameManagerUI._instance.Stage5_Star_ClearNum;
        data.Stage6Star = GameManagerUI._instance.Stage6_Star_ClearNum;
        data.Stage7Star = GameManagerUI._instance.Stage7_Star_ClearNum;
        data.Stage8Star = GameManagerUI._instance.Stage8_Star_ClearNum;
        data.Stage9Star = GameManagerUI._instance.Stage9_Star_ClearNum;
        data.Stage10Star = GameManagerUI._instance.Stage10_Star_ClearNum;


        string str = JsonUtility.ToJson(data);

        Debug.Log("ToJson : " + str);

        Data data2 = JsonUtility.FromJson<Data>(str);
        data2.printData();

        // file save 
        Data data3 = new Data();
        File.WriteAllText(Application.dataPath + "/StarData.json", JsonUtility.ToJson(data3));

        // file load 
        string str2 = File.ReadAllText(Application.dataPath + "/StarData.json");

        Data data4 = JsonUtility.FromJson<Data>(str2);
        data4.printData();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
