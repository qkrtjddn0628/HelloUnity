using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //public GameObject itemGo;       // Go : GameObject 
    public List<GameObject> itemGos;    //<GameObject>게임오브젝트를 타입을 만들어 게임오브젝트 타입을 집어 넣을수 있게 한다

    private void Awake()
    {
        //Debug.Log(itemGo);

        //Item item = itemGo.GetComponent<Item>();

        //Debug.Log($"{item.itemName}");
        //Debug.Log($"{item.attackSpeed}");
        //Debug.Log($"{item.damage}");
        //Debug.Log($"{item.isBroken}");

        //itemGos를 순회 하면서 아이템들의 이름을 출력하고 싶다.
        // 1. 게임오브젝트를 만들기
        // 2. 아이템 컴포넌트를 부착하기
        // 3. 비어있는 이름에 부착하기
        // 4. 인벤토리에 추가(어싸인)하기
        // 5. 순회하면서 포문 사용

        // 장검
        // 단검
        // 활

        Debug.Log($"<color=Yellow>{itemGos.Count}</color>");
        
        for(int i = 0; i < this.itemGos.Count;i++)
        {
            // 리스트의 인덱스에 해당하는 요소의 값 출력
            //Debug.Log($"{1} -> {this.itemGos[i]}");

            GameObject itemGo = this.itemGos[i];
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"{item.itemName}");

        }

    }

    
}
