using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarStar : MonoBehaviour
{
    public int Star;
    public bool State;
    public bool State2;
    public bool State3;
    public GameObject Target;
    public GameObject Target_1;
    public GameObject Target2;
    public GameObject Target2_1;
    public GameObject Target3;
    public GameObject Target3_1;
    //instage=stage 스테이지 셀렉트=셀렉트
    //태그 Star_1에 Getcomponent Star1 선언을 하는법.
    //태그에다가 전용 선언을 붙혀서 그 선언을 겟컴포넌트로 하면 되지 않을까
    //조건1.스타 오브젝트 먹으면 스타 함수+1, 그리고 그 스타를 상단 Ui에 띄움, 그리고 최종 스테이지 종료때
    //스타 갯수 표기 및 그걸 Ui로  SceneManager.LoadScene("씬 이름");


    void Start()
    {
        State = false;
        State2 = false;
        State3 = false;
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Star_1")
        {
            Star += 1;
        }
        if (other.tag == "Star_2")
        {
            Star += 1;
        }
        if (other.tag == "Star_3")
        {
            Star += 1;
        }
    }
        // Update is called once per frame
        void Update()
        {

        if (Input.GetMouseButtonDown(0))
        {
            if (State == true)
            {
                Target.SetActive(false);
                Target_1.SetActive(false);
                State = false;
            }
            else
            {
                Target.SetActive(true);
                Target_1.SetActive(true);
                State = true;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (State2 == true)
            {
                Target2.SetActive(false);
                Target2_1.SetActive(false);
                State2 = false;
            }
            else
            {
                Target2.SetActive(true);
                Target2_1.SetActive(true);
                State2 = true;
            }
        }

        if (Input.GetMouseButtonDown(2))
        {

            if (State3 == true)
            {
                Target3.SetActive(false);
                Target3_1.SetActive(false);
                State3 = false;
            }
            else
            {
                Target3.SetActive(true);
                Target3_1.SetActive(true);
                State3 = true;
            }
        
            
        }

        }
    }

