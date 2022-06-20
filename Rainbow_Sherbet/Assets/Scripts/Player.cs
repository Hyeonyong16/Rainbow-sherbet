using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CameraControll cameraCon;
    Renderer playerColor;
    public Animator ani;

    public float moveSpeed =30f;
    public float currTime; // �����帣�½ð�
    public bool checkChangeColor = false;

    public float limitTime = 1.2f; // ������ �ٲ�� ���ѽð� (Default value : 1.2f)

    public GameObject teleport;
    public GameObject teleport2;
    public GameObject teleport3;

    public int count = -1; // �ٷ� �����Ͽ� 0���� ������ �ε���0������ ���� ������
    //public int colorLimitCount = 0; // ���������� �÷� ������ ���� ����

    public bool ch = false;
    public Vector3 targetPos;
    private Vector3 goPos;
    
    public int[] color_count = new int[7]; // ����

    Rigidbody rb;
    public float power = 30f;

    public GameObject ClearScreen;
    public GameObject FailedScreen;

    private void Start()
    {
        ani = GetComponent<Animator>();
        playerColor = gameObject.GetComponent<Renderer>();
        rb = gameObject.GetComponent<Rigidbody>();
        InitPos();
        Color_Init();
        //InitColorLimit(); //���� �ر�
    }

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection;
        //ani.SetBool("move", true);
        ch = true;    

    }

    public void Rotation(float angle)
    {
        this.transform.localEulerAngles = new Vector3(-90,angle,0);
        Debug.Log("aaaaa1321313");
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

    public void ColorChange(int color) // ������ ���ڷ� �����ϱ� 
    {
        switch (color)
        {
            case 0:
                playerColor.material.color = Color.red; // ��
                break;
            case 1:
                playerColor.material.color = new Color(255/255f , 140/255f, 0/255f); // �� (������̶� ���кҰ��� ��ũ�������κ���)
                break;
            case 2:
                playerColor.material.color = new Color(255 / 255f, 255 / 255f, 0 / 255f); ;// ��
                break;
            case 3:
                playerColor.material.color = new Color(0 / 255f, 128 / 255f, 0 / 255f);//��
                break;
            case 4:
                playerColor.material.color =Color.blue;//�� (���� ����������  Deep Sky Blue �� ����)
                break;
            case 5:
                playerColor.material.color = new Color(0 / 255f, 0 / 255f, 128 / 255f);//��
                break;
            case 6:
                playerColor.material.color = new Color(128 / 255f, 0 / 255f, 128 / 255f);//��
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
            cameraCon.transform.localEulerAngles = new Vector3(12, 0, 0);
            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 5.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;
            Debug.Log("teleport check");
        }
        else if (coll.gameObject.tag == "Teleport2")
        {
            targetPos = new Vector3(teleport2.gameObject.transform.position.x, teleport2.gameObject.transform.position.y + 1f, teleport2.gameObject.transform.position.z);
            transform.position = targetPos;
            cameraCon.transform.localEulerAngles = new Vector3(12, 0, 0);
            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 5.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;
            Debug.Log("teleport check");
        }

        else if (coll.gameObject.tag == "Teleport3")
        {
            targetPos = new Vector3(teleport3.gameObject.transform.position.x, teleport3.gameObject.transform.position.y + 1f, teleport3.gameObject.transform.position.z);
            transform.position = targetPos;
            cameraCon.transform.localEulerAngles = new Vector3(12, 0, 0);
            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 5.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;
            Debug.Log("teleport check");
        }    

        if (coll.gameObject.tag == "Turtle")
        {
            limitTime = 2.0f;
            Debug.Log("Oops turtle!");
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "Rabbit")
        {
            limitTime = 0.8f;
            Debug.Log("Wow Rabbit");
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag == "Star")
        {
            //�̰� ���ľ��� ���� ����
            GameManagerUI._instance.stageNumStars = GameManagerUI._instance.stageNumStars+1;
            Debug.Log("Get Star~~");
            Destroy(coll.gameObject);
            
        }


        if (coll.gameObject.tag == "Blocks")
        {
            if (coll.gameObject.GetComponent<Renderer>().material.color != this.gameObject.GetComponent<Renderer>().material.color)
            {
                if (!checkChangeColor)
                {             
                    FailedScreen.SetActive(true);
                    Time.timeScale = 0;
                    Debug.Log("No Matches!!!");
                }
               
            }
        }


        if (coll.gameObject.tag == "FinishBlock")
        {
            //�������� Ŭ����â ����           
            ClearScreen.SetActive(true);
            Debug.Log("Stage End");
            Time.timeScale = 0;
            Debug.Log(Time.timeScale);

            //Ŭ���� ���� �� ������ ����
            GameManagerJsonParser gameManagerJsonParser = GameObject.Find("GameManagerUI").GetComponent<GameManagerJsonParser>();
            gameManagerJsonParser.SaveStarDataToJson();

        }

        if (coll.gameObject.tag == "TrashBlock")
        {
            //����â �ֱ� 
            FailedScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Blocks")
        {
            if (coll.gameObject.GetComponent<Renderer>().material.color != this.gameObject.GetComponent<Renderer>().material.color)
            {
                if (!checkChangeColor)
                {
                    FailedScreen.SetActive(true);
                    Time.timeScale = 0;
                    Debug.Log("No Matches!!!");
                }
               
            }
        }
    }



    private void FixedUpdate()
    {
        currTime += Time.deltaTime;
        //checkTime += Time.deltaTime;

        //rb.AddForce(Vector3.forward * power);

       

        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if (currTime > limitTime)
        {
           


            count++;
            if (count > GameManagerUI._instance.colorLimitCount)//GameManagerUI._instance.colorLimitCount) // �ϼ��� ����
                count = 0;

            ColorChange(color_count[count]);
                      
            currTime = 0;
            
        }
        if ((currTime < 0.4f && currTime >= 0f) || (currTime >= 1.0f && currTime <= 1.2f))
            checkChangeColor = true;
        else if( currTime > 0.4f && currTime < 1.0f)
            checkChangeColor = false;
        //if (ch)
        //{
        //    ani.SetBool("move", false);
        //    ch = false;
        //}
    }
}
