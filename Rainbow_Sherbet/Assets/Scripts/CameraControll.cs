using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Vector3 cameraPos;


    void Start()
    {
        cameraPos = transform.position;
    }

    public void Move(Vector3 moveDirection)
    {
        cameraPos += moveDirection;
        transform.position = cameraPos;
    }

    void Update()
    {
        
    }
}
