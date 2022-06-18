using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTotitle : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("MainTitle");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}