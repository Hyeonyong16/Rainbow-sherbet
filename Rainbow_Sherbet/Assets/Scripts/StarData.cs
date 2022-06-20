using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarData : MonoBehaviour
{
    public Image[] StarImage; //�� ������������ ��Ÿ�̹��� ǥ������� �Ǵ� ��  012 = ������������ ���̴� �� , 345 = Ŭ���� ui ��, 678 = ���� ui ��

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Stage1_Star_Cal();
        Stage2_Star_Cal();
        Stage3_Star_Cal();
        Stage4_Star_Cal();
        Stage5_Star_Cal();
        Stage6_Star_Cal();
        Stage7_Star_Cal();
        Stage8_Star_Cal();
        Stage9_Star_Cal();
        Stage10_Star_Cal();
    }


    public void Stage1_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                GameManagerUI._instance.Stage1_Star_EndNum = 1;
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                GameManagerUI._instance.Stage1_Star_EndNum = 2;
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                GameManagerUI._instance.Stage1_Star_EndNum = 3;
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }

        if (GameManagerUI._instance.Stage1_Star_ClearNum > GameManagerUI._instance.Stage1_Star_EndNum)
        {
            Debug.Log("1������������: " + GameManagerUI._instance.Stage1_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage1_Star_ClearNum <= GameManagerUI._instance.Stage1_Star_EndNum)
        {
            GameManagerUI._instance.Stage1_Star_ClearNum = GameManagerUI._instance.Stage1_Star_EndNum;
        }
    }

    public void Stage2_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {

                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {

                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage2_Star_ClearNum > GameManagerUI._instance.Stage2_Star_EndNum)
        {
            Debug.Log("2������������: " + GameManagerUI._instance.Stage2_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage2_Star_ClearNum <= GameManagerUI._instance.Stage2_Star_EndNum)
        {
            GameManagerUI._instance.Stage2_Star_ClearNum = GameManagerUI._instance.Stage2_Star_EndNum;
        }

    }

    public void Stage3_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage3_Star_ClearNum > GameManagerUI._instance.Stage3_Star_EndNum)
        {
            Debug.Log("3������������: " + GameManagerUI._instance.Stage3_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage3_Star_ClearNum <= GameManagerUI._instance.Stage3_Star_EndNum)
        {
            GameManagerUI._instance.Stage3_Star_ClearNum = GameManagerUI._instance.Stage3_Star_EndNum;
        }
    }

    public void Stage4_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage4_Star_ClearNum > GameManagerUI._instance.Stage4_Star_EndNum)
        {
            Debug.Log("4������������: " + GameManagerUI._instance.Stage4_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage4_Star_ClearNum <= GameManagerUI._instance.Stage4_Star_EndNum)
        {
            GameManagerUI._instance.Stage4_Star_ClearNum = GameManagerUI._instance.Stage4_Star_EndNum;
        }
    }

    public void Stage5_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage5")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage5_Star_ClearNum > GameManagerUI._instance.Stage5_Star_EndNum)
        {
            Debug.Log("5������������: " + GameManagerUI._instance.Stage5_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage5_Star_ClearNum <= GameManagerUI._instance.Stage5_Star_EndNum)
        {
            GameManagerUI._instance.Stage5_Star_ClearNum = GameManagerUI._instance.Stage5_Star_EndNum;
        }
    }

    public void Stage6_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage6")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage6_Star_ClearNum > GameManagerUI._instance.Stage6_Star_EndNum)
        {
            Debug.Log("6������������: " + GameManagerUI._instance.Stage6_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage6_Star_ClearNum <= GameManagerUI._instance.Stage6_Star_EndNum)
        {
            GameManagerUI._instance.Stage6_Star_ClearNum = GameManagerUI._instance.Stage6_Star_EndNum;
        }
    }

    public void Stage7_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage7")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage7_Star_ClearNum > GameManagerUI._instance.Stage7_Star_EndNum)
        {
            Debug.Log("7������������: " + GameManagerUI._instance.Stage7_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage7_Star_ClearNum <= GameManagerUI._instance.Stage7_Star_EndNum)
        {
            GameManagerUI._instance.Stage7_Star_ClearNum = GameManagerUI._instance.Stage7_Star_EndNum;
        }
    }

    public void Stage8_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage8")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage8_Star_ClearNum > GameManagerUI._instance.Stage8_Star_EndNum)
        {
            Debug.Log("8������������: " + GameManagerUI._instance.Stage8_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage8_Star_ClearNum <= GameManagerUI._instance.Stage8_Star_EndNum)
        {
            GameManagerUI._instance.Stage8_Star_ClearNum = GameManagerUI._instance.Stage8_Star_EndNum;
        }
    }

    public void Stage9_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage9")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage9_Star_ClearNum > GameManagerUI._instance.Stage9_Star_EndNum)
        {
            Debug.Log("9������������: " + GameManagerUI._instance.Stage9_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage9_Star_ClearNum <= GameManagerUI._instance.Stage9_Star_EndNum)
        {
            GameManagerUI._instance.Stage9_Star_ClearNum = GameManagerUI._instance.Stage9_Star_EndNum;
        }
    }

    public void Stage10_Star_Cal()
    {
        if (SceneManager.GetActiveScene().name == "Stage10")
        {
            if (GameManagerUI._instance.stageNumStars == 1)
            {
                StarImage[0].gameObject.SetActive(true);
                StarImage[3].gameObject.SetActive(true);
                StarImage[6].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 2)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[1].gameObject.SetActive(true);
                StarImage[4].gameObject.SetActive(true);
                StarImage[7].gameObject.SetActive(true);
            }
            else if (GameManagerUI._instance.stageNumStars == 3)
            {
                //StarImage[0].gameObject.SetActive(true);
                StarImage[2].gameObject.SetActive(true);
                StarImage[5].gameObject.SetActive(true);
                StarImage[8].gameObject.SetActive(true);
            }
        }
        if (GameManagerUI._instance.Stage10_Star_ClearNum > GameManagerUI._instance.Stage10_Star_EndNum)
        {
            Debug.Log("10������������: " + GameManagerUI._instance.Stage10_Star_EndNum);
            return;
        }
        else if (GameManagerUI._instance.Stage10_Star_ClearNum <= GameManagerUI._instance.Stage10_Star_EndNum)
        {
            GameManagerUI._instance.Stage10_Star_ClearNum = GameManagerUI._instance.Stage10_Star_EndNum;
        }
    }

}
