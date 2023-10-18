using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public bool isInRange; // �ж�����Ƿ��ڽ�����Χ��
    public KeyCode interactKey; // ��������
    public GameObject player; // ��Ҷ���
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
        // ������������������б���д
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
