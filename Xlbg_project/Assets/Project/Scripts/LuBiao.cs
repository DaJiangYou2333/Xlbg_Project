using UnityEngine;
using TMPro;

public class RoadSign : MonoBehaviour
{
    public TMP_Text roadSignText;
    private bool isPlayerInRange = false;

    private void Awake() // ʹ��Awake��Start����
    {
        roadSignText.enabled = false; // Ĭ�������ı�
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ToggleText();
        }
    }

    private void ToggleText()
    {
        roadSignText.enabled = !roadSignText.enabled;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            roadSignText.enabled = false; // ������뿪ʱ�������ı�
        }
    }
}