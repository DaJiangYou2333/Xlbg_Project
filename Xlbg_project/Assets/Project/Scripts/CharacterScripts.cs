using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterScripts : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 lookDirection = new Vector2(1, 0);

    public float playerMoveSpeed = 0.12f;

    // �ڵ�һ֮֡ǰ���� Start ����
    private void Start()
    {
        // ��ȡ��ɫ���ϵ� Rigidbody2D �� Animator ���
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // ����������ƶ�����ʱ���������������
    private void OnMovement(InputValue value)
    {
        // ����ҵ�����ת����һ�� 2D ����
        movement = value.Get<Vector2>();

        // �����������ƶ������½�ɫ�ĳ��򲢲����ƶ�����
        if (movement != Vector2.zero)
        {
            lookDirection = movement;
            animator.SetFloat("x", movement.x);
            animator.SetFloat("y", movement.y);
            animator.SetBool("Run", true); // ���� "Run" Ϊ true����ʼ�����ƶ�����
        }
        else
        {
            // ������û���ƶ����ý�ɫ�泯�ϴ��ƶ��ķ��򲢲������ö���
            animator.SetFloat("x", lookDirection.x);
            animator.SetFloat("y", lookDirection.y);
            animator.SetBool("Run", false); // ���� "Run" Ϊ false����ʼ�������ö���
        }
    }

    // FixedUpdate ÿ��Ĭ�ϱ�����20�Σ�ͨ�������������
    private void FixedUpdate()
    {
        // ���½�ɫ��λ��
        rb.MovePosition(rb.position + movement * playerMoveSpeed);
    }
}
