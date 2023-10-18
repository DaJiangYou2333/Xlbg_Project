using UnityEngine;
using System.Collections.Generic;

public class Inventory1 : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>(); // 存储玩家的道具
    public int capacity = 10; // 背包的容量

    // 添加道具到背包
    public bool AddItem(GameObject item)
    {
        if (items.Count < capacity)
        {
            items.Add(item);
            Debug.Log(item.name + " added to inventory.");
            return true;
        }
        else
        {
            Debug.Log("Inventory full!");
            return false;
        }
    }
}
