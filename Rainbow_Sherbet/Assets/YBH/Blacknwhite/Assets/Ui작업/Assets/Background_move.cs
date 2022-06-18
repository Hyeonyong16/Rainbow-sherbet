using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.right * 0.07f, Space.World);

        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Vector3.left * 0.07f, Space.World);
        }

    }
}
