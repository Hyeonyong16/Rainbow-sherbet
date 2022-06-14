using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 targetPos;

    private void Start()
    {
        targetPos = transform.position;
    }

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection;
    }

    public void Rotation(float angle)
    {
        this.transform.localEulerAngles = new Vector3(0,angle,0);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}
