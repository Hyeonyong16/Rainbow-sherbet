using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSignalControll : MonoBehaviour
{
    public Player player;
    public Sprite[] colorSprites = new Sprite[7];
    public int checkNum = 0;

    private void FixedUpdate()
    {
        ColorSignalPlay();
    }




    void ColorSignalPlay()
    {
        if (GameManagerUI._instance.colorLimitCount == 1) // GameManagerUI._instance.colorLimitCount ºñ±³
        {
            if (player.count == -1)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[0];
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[1];
            }
            else if (player.count == 0)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count];
            }
            else if (player.count == 1)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count - 1];
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count];
            }
        }

        else if (GameManagerUI._instance.colorLimitCount == 2)
        {
            if (player.count < 0)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//2
            }
            else if (player.count == 0)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//1
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//2
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count];//0
            }
            else if (player.count == 1)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//2
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 1];//0
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count];//1
            }
            else if (player.count == 2)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count]; //2
            }
        }

        else if (GameManagerUI._instance.colorLimitCount == 3)
        {
            if (player.count < 0) //-1
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//3
            }
            else if (player.count == 0)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//1
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//2
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//3
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count];//0
            }
            else if (player.count == 1)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//2
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//3
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 1];//0
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count];//1
            }
            else if (player.count == 2)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //3
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //0
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //1
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count]; //2
            }
            else if (player.count == 3)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count]; //3
            }
        }

        else if (GameManagerUI._instance.colorLimitCount == 4)
        {
            if (player.count < 0) //-1
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//3
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count + 5];//4
            }
            else if (player.count == 0) //0
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//1
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//2
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//3
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count +4];//4
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count];//0
            }
            else if (player.count == 1)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//2
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//3
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//4
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 1];//0
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count];//1
            }
            else if (player.count == 2)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //3
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2]; //4
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //0
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //1
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count]; //2
            }
            else if (player.count == 3)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //4
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //0
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //1
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //2
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count]; //3
            }

            else if (player.count == 4)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count - 4]; //0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //3
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count]; //4
            }

        }

        else if (GameManagerUI._instance.colorLimitCount == 5)
        {
            if (player.count < 0) //-1
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//3
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count + 5];//4
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count + 6];//5
            }
            else if (player.count == 0) //0
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//1
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//2
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//3
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//4
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count + 5];//5
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count];//0
            }
            else if (player.count == 1) 
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//2
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//3
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//4
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//5
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 1];//0
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count];//1
            }
            else if (player.count == 2)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //3
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2]; //4
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3]; //5
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //0
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //1
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count]; //2
            }
            else if (player.count == 3)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //4
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2]; //5
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //0
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //1
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //2
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count]; //3
            }

            else if (player.count == 4)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //5
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 4]; //0
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //1
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //2
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //3
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count]; //4
            }

            else if (player.count == 5)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count - 5]; //0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 4]; //1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //3
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //4
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count]; //5
            }
        }

        else if (GameManagerUI._instance.colorLimitCount == 6)
        {
            if (player.count < 0) //-1
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//3
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count + 5];//4
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count + 6];//5
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count + 7];//6
            }
            else if (player.count == 0) //0
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//1
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//2
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//3
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//4
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count + 5];//5
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count + 6];//6
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count];//0
            }
            else if (player.count == 1)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1];//2
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2];//3
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3];//4
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4];//5
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count + 5];//6
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count - 1];//0
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count];//1
            }
            else if (player.count == 2)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //3
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2]; //4
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3]; //5
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count + 4]; //6
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //0
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //1
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count]; //2
            }
            else if (player.count == 3)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //4
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2]; //5
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count + 3]; //6
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //0
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //1
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //2
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count]; //3
            }

            else if (player.count == 4)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //5
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count + 2]; //6
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 4]; //0
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //1
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //2
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //3
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count]; //4
            }

            else if (player.count == 5)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count + 1]; //6
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 5]; //0
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 4]; //1
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //2
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //3
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //4
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count]; //5
            }

            else if (player.count == 6)
            {
                this.transform.GetChild(0).GetComponent<Image>().sprite = colorSprites[player.count - 6]; //0
                this.transform.GetChild(1).GetComponent<Image>().sprite = colorSprites[player.count - 5]; //1
                this.transform.GetChild(2).GetComponent<Image>().sprite = colorSprites[player.count - 4]; //2
                this.transform.GetChild(3).GetComponent<Image>().sprite = colorSprites[player.count - 3]; //3
                this.transform.GetChild(4).GetComponent<Image>().sprite = colorSprites[player.count - 2]; //4
                this.transform.GetChild(5).GetComponent<Image>().sprite = colorSprites[player.count - 1]; //5
                this.transform.GetChild(6).GetComponent<Image>().sprite = colorSprites[player.count]; //6
            }
        }

    }

}
