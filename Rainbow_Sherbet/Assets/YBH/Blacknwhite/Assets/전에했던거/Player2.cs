using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    public float force = 300.0f;

    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { // ↑키로 forward(전).
            this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
            // this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        { // ↓키로 back(후).
            this.transform.Translate(Vector3.back * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { // ←키로 left(좌).
            this.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { // →키로 right(우).
            this.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gall 2")
        {
            SceneManager.LoadScene("Win");
        }

        if (other.tag == "Fire")
        {
            SceneManager.LoadScene("lose");
        }


    }
}
