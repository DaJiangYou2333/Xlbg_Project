using UnityEngine;
using System.Collections.Generic;

public class Inventory1 : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>(); // �洢��ҵĵ���
    public int capacity = 10; // ����������

    // ��ӵ��ߵ�����
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
