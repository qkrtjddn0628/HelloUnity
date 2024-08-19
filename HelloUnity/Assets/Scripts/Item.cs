using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // 멤버 변수 정의
    public int damage;
    public float attackSpeed;
    public bool isBroken;
    public string itemName;


    private void Awake()
    {
        Debug.Log("Awake메서드 호출됨.");
        // 공격력 : 0
        Debug.Log($"공격력 : {this.damage}");

        Debug.LogFormat("아이템명 : {0}", this.itemName);
        Debug.LogFormat("공격력 : {0}", this.damage);
        Debug.LogFormat("공격속도 : {0}", this.attackSpeed);
        Debug.LogFormat("파괴여부 : {0}", this.isBroken);


    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start 메서드 호출됨");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");

    }
}
