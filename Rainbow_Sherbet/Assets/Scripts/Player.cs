using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CameraControll cameraCon;
    Renderer playerColor;
    public Animator ani;

    public float moveSpeed =30f;
    public float currTime; // 지금흐르는시간
    public float limitTime = 1.2f; // 색상이 바뀌는 제한시간 (Default value : 1.2f)

    public GameObject teleport;
    public GameObject teleport2;
    public GameObject teleport3;

    public int count = -1; // 바로 증가하여 0부터 시작해 인덱스0번부터 색상 보여줌
    public int colorLimitCount = 0; // 스테이지별 컬러 제한을 위한 변수

   
    public Vector3 targetPos;
    private Vector3 goPos;
    
    public int[] color_count = new int[7]; // 예시

    Rigidbody rb;
    public float power = 30f;
    private void Start()
    {
        ani = GetComponent<Animator>();
        playerColor = gameObject.GetComponent<Renderer>();
        rb = gameObject.GetComponent<Rigidbody>();
        InitPos();
        Color_Init();
        //InitColorLimit(); //추후 해금
    }

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection;
        ani.SetBool("move", true);
        //switch (moveDirection)
        //{   case 0: // 앞으로
        //        goPos.x = targetPos.x;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z + 1;
        //        targetPos = Vector3.MoveTowards(targetPos, goPos, moveSpeed );
        //        break;
        //    case 1: //뒤로
        //        goPos.x = targetPos.x;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z - 1;
        //        targetPos = Vector3.MoveTowards(targetPos, goPos, moveSpeed );
        //        break;
        //    case 2: //오른쪽
        //        goPos.x = targetPos.x +1;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z;
        //        targetPos = Vector3.MoveTowards(transform.position, goPos, moveSpeed );
        //        break;
        //    case 3: //왼쪽
        //        goPos.x = targetPos.x - 1;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z;
        //        targetPos = Vector3.MoveTowards(transform.position, goPos, moveSpeed );
        //        break;
        //    default:
        //        break;
        //}
       // transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed );

    }

    public void Rotation(float angle)
    {
        this.transform.localEulerAngles = new Vector3(0,angle,0);
    }

    void InitColorLimit()
    {
        switch (GameManagerUI._instance.stageNum)
        {
            case 1:
                colorLimitCount = 2;
                break;
            case 2:
                colorLimitCount = 2;
                break;
            case 3:
                colorLimitCount = 3;
                break;
            case 4:
                colorLimitCount = 4;
                break;
            case 5:
                colorLimitCount = 4;
                break;
            case 6:
                colorLimitCount = 5;
                break;
            case 7:
                colorLimitCount = 5;
                break;
            case 8:
                colorLimitCount = 6;
                break;
            case 9:
                colorLimitCount = 7;
                break;
            case 10:
                colorLimitCount = 7;
                break;
            default:
                break;
        }

    }

    void InitPos()
    {
        targetPos = transform.position;
    }

    void Color_Init()
    {
        color_count[0] = 0;
        color_count[1] = 1;
        color_count[2] = 2;
        color_count[3] = 3;
        color_count[4] = 4;
        color_count[5] = 5;
        color_count[6] = 6;
    }

    public void ColorChange(int color) // 색상을 숫자로 규정하기 
    {
        switch (color)
        {
            case 0:
                playerColor.material.color = Color.red; // 빨
                break;
            case 1:
                playerColor.material.color = new Color(255/255f , 140/255f, 0/255f); // 주 (노란색이랑 구분불가라 다크오렌지로변경)
                break;
            case 2:
                playerColor.material.color = Color.yellow;// 노
                break;
            case 3:
                playerColor.material.color = Color.green;//초
                break;
            case 4:
                playerColor.material.color =Color.blue;//파 (남색 구분을위해  Deep Sky Blue 로 변경)
                break;
            case 5:
                playerColor.material.color = new Color(0 / 255f, 0 / 255f, 128 / 255f);//남
                break;
            case 6:
                playerColor.material.color = new Color(128 / 255f, 0 / 255f, 128 / 255f);//보
                break;

            default:
                break;
        }

    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Teleport")
        {
            targetPos = new Vector3(teleport.gameObject.transform.position.x, teleport.gameObject.transform.position.y + 1f, teleport.gameObject.transform.position.z);
            transform.position = targetPos;
            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 1.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;
            Debug.Log("teleport check");
        }
        else if (coll.gameObject.tag == "Teleport2")
        {
            targetPos = new Vector3(teleport2.gameObject.transform.position.x, teleport2.gameObject.transform.position.y + 1f, teleport2.gameObject.transform.position.z);
            transform.position = targetPos;
            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 1.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;
            Debug.Log("teleport check");
        }

        else if (coll.gameObject.tag == "Teleport3")
        {
            targetPos = new Vector3(teleport3.gameObject.transform.position.x, teleport3.gameObject.transform.position.y + 1f, teleport3.gameObject.transform.position.z);
            transform.position = targetPos;
            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 1.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;
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

        if (coll.gameObject.tag == "Star")
        {
            //GameManagerUI._instance.stageNumStars++;                     
            Destroy(coll.gameObject);
            Debug.Log("Get Star~~");
        }


        if (coll.gameObject.tag == "Blocks")
        {
            if (coll.gameObject.GetComponent<Renderer>().material.color != this.gameObject.GetComponent<Renderer>().material.color)
            {
                Debug.Log("No Matches!!!");
            }
        }

    }



    private void Update()
    {
        currTime += Time.deltaTime;

        //rb.AddForce(Vector3.forward * power);

        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if (currTime > limitTime)
        {
            count++;
            if (count > colorLimitCount)
                count = 0;

            ColorChange(color_count[count]);
                      
            currTime = 0;
            
        }

    }
}
