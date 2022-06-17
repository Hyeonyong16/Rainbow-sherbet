using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Vector3 cameraPos;
    public Player player; // 플레이어 코드


    void Start()
    {
        cameraPos = transform.position;
    }

    public void Move()
    {
        cameraPos = new Vector3(player.targetPos.x, player.targetPos.y + 1.0f, player.targetPos.z - 10.0f);
        transform.position = cameraPos;
        //if (player.teleportButton)
        //{
        //    cameraPos = new Vector3(player.targetPos.x, player.targetPos.y + 1.0f, player.targetPos.z - 10.0f);
        //    transform.position = cameraPos;
        //}
        //else
        //{
        //    cameraPos += moveDirection;
        //    transform.position = cameraPos;
        //}
    }

    void Update()
    {
        //cameraPos = new Vector3(player.targetPos.x, player.targetPos.y + 1.0f, player.targetPos.z - 10.0f);
        //transform.position = cameraPos;
    }
}
