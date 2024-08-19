using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //public GameObject itemGo;       // Go : GameObject 
    public List<GameObject> itemGos;    //<GameObject>���ӿ�����Ʈ�� Ÿ���� ����� ���ӿ�����Ʈ Ÿ���� ���� ������ �ְ� �Ѵ�

    private void Awake()
    {
        //Debug.Log(itemGo);

        //Item item = itemGo.GetComponent<Item>();

        //Debug.Log($"{item.itemName}");
        //Debug.Log($"{item.attackSpeed}");
        //Debug.Log($"{item.damage}");
        //Debug.Log($"{item.isBroken}");

        //itemGos�� ��ȸ �ϸ鼭 �����۵��� �̸��� ����ϰ� �ʹ�.
        // 1. ���ӿ�����Ʈ�� �����
        // 2. ������ ������Ʈ�� �����ϱ�
        // 3. ����ִ� �̸��� �����ϱ�
        // 4. �κ��丮�� �߰�(�����)�ϱ�
        // 5. ��ȸ�ϸ鼭 ���� ���

        // ���
        // �ܰ�
        // Ȱ

        Debug.Log($"<color=Yellow>{itemGos.Count}</color>");
        
        for(int i = 0; i < this.itemGos.Count;i++)
        {
            // ����Ʈ�� �ε����� �ش��ϴ� ����� �� ���
            //Debug.Log($"{1} -> {this.itemGos[i]}");

            GameObject itemGo = this.itemGos[i];
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"{item.itemName}");

        }

    }

    
}
