using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public float interval;
    // Start is called before the first frame update
    IEnumerator Start()
    { // yield�� ����ϱ� ���� IEnumerator type���� return
        while (true)
        {
            Instantiate(wallPrefab, transform.position, transform.rotation);
            // �÷��� �����͸� �ϳ��� return �� ���� ���� ��ġ ��� (Unity�� coroutine ����)
            yield return new WaitForSeconds(interval);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
