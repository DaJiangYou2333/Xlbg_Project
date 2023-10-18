using UnityEngine;
using TMPro;

public class RoadSign : MonoBehaviour
{
    public TMP_Text roadSignText;
    private bool isPlayerInRange = false;

    private void Awake() // 使用Awake或Start方法
    {
        roadSignText.enabled = false; // 默认隐藏文本
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
            roadSignText.enabled = false; // 当玩家离开时，隐藏文本
        }
    }
}