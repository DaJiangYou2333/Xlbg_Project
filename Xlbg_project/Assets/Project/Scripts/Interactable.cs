using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public bool isInRange; // 判断玩家是否在交互范围内
    public KeyCode interactKey; // 交互按键
    public GameObject player; // 玩家对象
    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKeyDown(interactKey))
        {
            Interact();
        }

    }
    
    public virtual void Interact()
    {
        // 这个方法会在派生类中被重写
        Debug.Log("Interacting with " + gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isInRange = true;
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            isInRange = false;
            Debug.Log("Player now out of range");
        }
    }
}
