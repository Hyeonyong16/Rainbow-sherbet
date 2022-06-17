using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Renderer playerColor;

    public float moveSpeed =30f;
    public float currTime; // 지금흐르는시간
    public float limitTime = 1.2f; // 색상이 바뀌는 제한시간

    public GameObject teleport; 

    public int count;
    public bool teleportButton = false;
    public bool teleportButton2 = false;
    private Vector3 targetPos;
    private Vector3 goPos;
    public Vector3 teleportPos;
    public int[] color_count = new int[3]; // 예시

    Rigidbody rb;
    public float power = 30f;
    private void Start()
    {
        targetPos = transform.position;
        teleportPos = teleport.gameObject.transform.position;
        playerColor = gameObject.GetComponent<Renderer>();
        Color_Init();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Move(int moveDirection)
    {
        //targetPos += moveDirection;
        switch (moveDirection)
        {   case 0: // 앞으로
                goPos.x = targetPos.x;
                goPos.y = targetPos.y;
                goPos.z = targetPos.z + 1;
                targetPos = Vector3.MoveTowards(targetPos, goPos, moveSpeed );
                break;
            case 1: //뒤로
                goPos.x = targetPos.x;
                goPos.y = targetPos.y;
                goPos.z = targetPos.z - 1;
                targetPos = Vector3.MoveTowards(targetPos, goPos, moveSpeed );
                break;
            case 2: //오른쪽
                goPos.x = targetPos.x +1;
                goPos.y = targetPos.y;
                goPos.z = targetPos.z;
                targetPos = Vector3.MoveTowards(transform.position, goPos, moveSpeed );
                break;
            case 3: //왼쪽
                goPos.x = targetPos.x - 1;
                goPos.y = targetPos.y;
                goPos.z = targetPos.z;
                targetPos = Vector3.MoveTowards(transform.position, goPos, moveSpeed );
                break;
            default:
                break;
        }
       // transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed );

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

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Teleport")
        {
            teleportButton = true;
            Debug.Log("teleport check");
        }

        if (coll.gameObject.tag == "Turtle")
        {
            limitTime = 2.0f;
            Debug.Log("Oops turtle!");

        }

        if (coll.gameObject.tag == "Rabbit")
        {
            limitTime = 0.8f;
            Debug.Log("Wow Rabbit");

        }
    }



    private void Update()
    {
        currTime += Time.deltaTime;

        //rb.AddForce(Vector3.forward * power);

        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if (currTime > limitTime)
        {
            //int i = 0;
            ColorChange(color_count[count]);
            count++;
            if (count >= 3)
                count = 0;

            currTime = 0;

        }

        if (teleportButton == true)
        {            
            targetPos = new Vector3(teleportPos.x, teleportPos.y + 1f, teleportPos.z);
            transform.position = targetPos;         
            teleportButton = false;
        }

    }
}
