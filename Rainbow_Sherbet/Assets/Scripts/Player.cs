using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Renderer playerColor;

    public float moveSpeed;
    public float currTime;

    public int count;

    private Vector3 targetPos;
    public int[] color_count = new int[3]; // 예시

    private void Start()
    {
        targetPos = transform.position;
        playerColor = gameObject.GetComponent<Renderer>();
        Color_Init();
    }

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection;
    }

    public void Rotation(float angle)
    {
        this.transform.localEulerAngles = new Vector3(0,angle,0);
    }

    //테스트-----------------
    void Color_Init()
    {
        color_count[0] = 1;
        color_count[1] = 0;
        color_count[2] = 2;
    }
    //----------------------
    public void ColorChange(int color) // 색상을 숫자로 규정하기 
    {
        switch (color)
        {
            case 0:
                playerColor.material.color = Color.red;
                break;
            case 1:
                playerColor.material.color = Color.green;
                break;
            case 2:
                playerColor.material.color = Color.blue;
                break;
            //case 3:
            //    break;
            //case 4:
            //    break;
            //case 5:
            //    break;
            //case 6:
            //    break;
            //case 7:
            //    break;
            //case 8:
            //    break;
            //case 9:
            //    break;
            default:
                break;
        }

    }

    private void Update()
    {
        currTime += Time.deltaTime;


        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if (currTime > 1.2f)
        {
            //int i = 0;
            ColorChange(color_count[count]);
            count++;
            if (count >= 3)
                count = 0;

            currTime = 0;

        }

    }
}
