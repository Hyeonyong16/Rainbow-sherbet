using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SelectStageStar : MonoBehaviour //스테이지 선택창 별 이미지 교체
{
    public Image[] StagesStarsImages;
    public Sprite[] ChangeSprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Change_Stage1_Star();
        Change_Stage2_Star();
        Change_Stage3_Star();
        Change_Stage4_Star();
        Change_Stage5_Star();
        Change_Stage6_Star();
        Change_Stage7_Star();
        Change_Stage8_Star();
        Change_Stage9_Star();
        Change_Stage10_Star();
    }

    public void Change_Stage1_Star()
    {
        if (GameManagerUI._instance.Stage1_Star_ClearNum == 1)
        {
            StagesStarsImages[0].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage1_Star_ClearNum == 2)
        {
            StagesStarsImages[0].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage1_Star_ClearNum == 3)
        {
            StagesStarsImages[0].sprite = ChangeSprites[2];
        }
    }

    public void Change_Stage2_Star()
    {
        if (GameManagerUI._instance.Stage2_Star_ClearNum == 1)
        {
            StagesStarsImages[1].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage2_Star_ClearNum == 2)
        {
            StagesStarsImages[1].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage2_Star_ClearNum == 3)
        {
            StagesStarsImages[1].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage3_Star()
    {
        if (GameManagerUI._instance.Stage3_Star_ClearNum == 1)
        {
            StagesStarsImages[2].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage3_Star_ClearNum == 2)
        {
            StagesStarsImages[2].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage3_Star_ClearNum == 3)
        {
            StagesStarsImages[2].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage4_Star()
    {
        if (GameManagerUI._instance.Stage4_Star_ClearNum == 1)
        {
            StagesStarsImages[3].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage4_Star_ClearNum == 2)
        {
            StagesStarsImages[3].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage4_Star_ClearNum == 3)
        {
            StagesStarsImages[3].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage5_Star()
    {
        if (GameManagerUI._instance.Stage5_Star_ClearNum == 1)
        {
            StagesStarsImages[4].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage5_Star_ClearNum == 2)
        {
            StagesStarsImages[4].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage5_Star_ClearNum == 3)
        {
            StagesStarsImages[4].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage6_Star()
    {
        if (GameManagerUI._instance.Stage6_Star_ClearNum == 1)
        {
            StagesStarsImages[5].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage6_Star_ClearNum == 2)
        {
            StagesStarsImages[5].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage6_Star_ClearNum == 3)
        {
            StagesStarsImages[5].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage7_Star()
    {
        if (GameManagerUI._instance.Stage7_Star_ClearNum == 1)
        {
            StagesStarsImages[6].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage7_Star_ClearNum == 2)
        {
            StagesStarsImages[6].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage7_Star_ClearNum == 3)
        {
            StagesStarsImages[6].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage8_Star()
    {
        if (GameManagerUI._instance.Stage8_Star_ClearNum == 1)
        {
            StagesStarsImages[7].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage8_Star_ClearNum == 2)
        {
            StagesStarsImages[7].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage8_Star_ClearNum == 3)
        {
            StagesStarsImages[7].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage9_Star()
    {
        if (GameManagerUI._instance.Stage9_Star_ClearNum == 1)
        {
            StagesStarsImages[8].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage9_Star_ClearNum == 2)
        {
            StagesStarsImages[8].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage9_Star_ClearNum == 3)
        {
            StagesStarsImages[8].sprite = ChangeSprites[2];
        }
    }
    public void Change_Stage10_Star()
    {
        if (GameManagerUI._instance.Stage10_Star_ClearNum == 1)
        {
            StagesStarsImages[9].sprite = ChangeSprites[0];
        }

        else if (GameManagerUI._instance.Stage10_Star_ClearNum == 2)
        {
            StagesStarsImages[9].sprite = ChangeSprites[1];
        }

        else if (GameManagerUI._instance.Stage10_Star_ClearNum == 3)
        {
            StagesStarsImages[9].sprite = ChangeSprites[2];
        }
    }
}
