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
        //큐브의 위치를 출력
        //클래스의 현재 인스턴스
        // CubeController클래스의 인스턴스
        //Transform transform = this.gameObject.GetComponent<Transform>();

        //this.transform : 위 Transform transform = this.gameObject.GetComponent<Transform>();을 짧게 요약한 것

        // CubeController 컴포넌트가 붙어 있는
        //게임오브젝트의 transform 컴포넌트의
        //position 속성의 값을 출력 // 필드 -> 멤버 변수
        // vecter는 struct(구조체)이다
        // 구조체는 상속할수 없으며, 클래스의 기본이 될수없다.
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

        // 매 프레임 마다 z 축으로 1식 증가
        this.transform.position += new Vector3(0, 0, 0.01f);
    }
}
