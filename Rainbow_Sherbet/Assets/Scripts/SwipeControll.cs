using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControll : MonoBehaviour
{
    public Player player; // �÷��̾� �ڵ�
    public CameraControll cameraCon; // ī�޶� ��Ʈ�� �ڵ�
    private Vector2 startPos; // ���� ��ġ
    public int pixelDistToDetect = 20; //��ġ �Ÿ�
    private bool fingerDown; //�������� ���� Ʈ����

    private void Update()
    {
        //----------------------------------------------------- mobile--------------------------------------------------------
        //if (fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //{
        //    startPos = Input.touches[0].position;
        //    fingerDown = true;
        //    Debug.Log("Touch");

        //}

        //if (fingerDown)
        //{
        //    if (Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe Up");
        //        player.Move(Vector3.up);
        //        player.Rotation(0);

        //    }
        //    else if (Input.touches[0].position.y <= startPos.y - pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe down");
        //        player.Move(Vector3.down);
        //        player.Rotation(180);

        //    }
        //    else if (Input.touches[0].position.x >= startPos.x + pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe Right");
        //        player.Move(Vector3.right);
        //        player.Rotation(90);

        //    }
        //    else if (Input.touches[0].position.x <= startPos.x - pixelDistToDetect)
        //    {
        //        fingerDown = false;
        //        Debug.Log("Swipe Left");
        //        player.Move(Vector3.left);
        //        player.Rotation(-90);

        //    }
        //}


        //----------------------------------------------------PC Test------------------------------------------------------------
        if (fingerDown == false && Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            fingerDown = true;
        }

        if (fingerDown)
        {
            if (Input.mousePosition.y >= startPos.y + pixelDistToDetect)
            {
                cameraCon.Move(Vector3.forward);
                fingerDown = false;
                Debug.Log("Swipe Up");
                player.Move(Vector3.forward);
                player.Rotation(0);

            }
            else if (Input.mousePosition.y <= startPos.y - pixelDistToDetect)
            {
                cameraCon.Move(Vector3.back);
                fingerDown = false;
                Debug.Log("Swipe Down");
                player.Move(Vector3.back);
                player.Rotation(180);

            }
            else if (Input.mousePosition.x >= startPos.x + pixelDistToDetect)
            {
                cameraCon.Move(Vector3.right);
                fingerDown = false;
                Debug.Log("Swipe right");
                player.Move(Vector3.right);
                player.Rotation(90);

            }
            else if (Input.mousePosition.x <= startPos.x - pixelDistToDetect)
            {
                cameraCon.Move(Vector3.left);
                fingerDown = false;
                Debug.Log("Swipe left");
                player.Move(Vector3.left);
                player.Rotation(-90);

            }


        }
    }
}
