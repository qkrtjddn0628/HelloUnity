using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //ť���� ��ġ�� ���
        //Ŭ������ ���� �ν��Ͻ�
        // CubeControllerŬ������ �ν��Ͻ�
        //Transform transform = this.gameObject.GetComponent<Transform>();

        //this.transform : �� Transform transform = this.gameObject.GetComponent<Transform>();�� ª�� ����� ��

        // CubeController ������Ʈ�� �پ� �ִ�
        //���ӿ�����Ʈ�� transform ������Ʈ��
        //position �Ӽ��� ���� ��� // �ʵ� -> ��� ����
        // vecter�� struct(����ü)�̴�
        // ����ü�� ����Ҽ� ������, Ŭ������ �⺻�� �ɼ�����.
        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        Debug.Log(transform.position.z);

        //transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.position);

        //this.transform.position = this.transform.position + new Vector3(1, 0, 0);

        // �� ������ ���� z ������ 1�� ����
        this.transform.position += new Vector3(0, 0, 0.01f);
    }
}
