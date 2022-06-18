using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CameraControll cameraCon;
    Renderer playerColor;

    public float moveSpeed =30f;
    public float currTime; // �����帣�½ð�
    public float limitTime = 1.2f; // ������ �ٲ�� ���ѽð� (Default value : 1.2f)

    public GameObject teleport;

    public int count = -1; // �ٷ� �����Ͽ� 0���� ������ �ε���0������ ���� ������
    public int colorLimitCount = 0; // ���������� �÷� ������ ���� ����

    public bool teleportButton = false;
    public bool teleportButton2 = false;
    public Vector3 targetPos;
    private Vector3 goPos;
    public Vector3 teleportPos;
    public int[] color_count = new int[7]; // ����

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

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection;
        //switch (moveDirection)
        //{   case 0: // ������
        //        goPos.x = targetPos.x;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z + 1;
        //        targetPos = Vector3.MoveTowards(targetPos, goPos, moveSpeed );
        //        break;
        //    case 1: //�ڷ�
        //        goPos.x = targetPos.x;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z - 1;
        //        targetPos = Vector3.MoveTowards(targetPos, goPos, moveSpeed );
        //        break;
        //    case 2: //������
        //        goPos.x = targetPos.x +1;
        //        goPos.y = targetPos.y;
        //        goPos.z = targetPos.z;
        //        targetPos = Vector3.MoveTowards(transform.position, goPos, moveSpeed );
        //        break;
        //    case 3: //����
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

    //�׽�Ʈ-----------------
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
    //----------------------
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
                playerColor.material.color = Color.yellow;// ��
                break;
            case 3:
                playerColor.material.color = Color.green;//��
                break;
            case 4:
                playerColor.material.color = new Color(0 / 255f, 191 / 255f, 255 / 255f);//�� (���� ����������  Deep Sky Blue �� ����)
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

        if (coll.gameObject.tag == "Star")
        {
            //��ȹ��� �������� �÷��ִ� ���� �߰� �κ�
            Debug.Log("Get Star~~");
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

        if (teleportButton == true)
        {            
            targetPos = new Vector3(teleportPos.x, teleportPos.y + 1f, teleportPos.z);
            transform.position = targetPos;

            cameraCon.cameraPos = new Vector3(targetPos.x, targetPos.y + 1.0f, targetPos.z - 10.0f);
            cameraCon.gameObject.transform.position = cameraCon.cameraPos;

            teleportButton = false;
        }

    }
}
