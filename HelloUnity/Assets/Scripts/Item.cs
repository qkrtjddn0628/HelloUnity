using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // ��� ���� ����
    public int damage;
    public float attackSpeed;
    public bool isBroken;
    public string itemName;


    private void Awake()
    {
        Debug.Log("Awake�޼��� ȣ���.");
        // ���ݷ� : 0
        Debug.Log($"���ݷ� : {this.damage}");

        Debug.LogFormat("�����۸� : {0}", this.itemName);
        Debug.LogFormat("���ݷ� : {0}", this.damage);
        Debug.LogFormat("���ݼӵ� : {0}", this.attackSpeed);
        Debug.LogFormat("�ı����� : {0}", this.isBroken);


    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start �޼��� ȣ���");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");

    }
}
