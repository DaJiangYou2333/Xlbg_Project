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

    // 在第一帧之前调用 Start 函数
    private void Start()
    {
        // 获取角色身上的 Rigidbody2D 和 Animator 组件
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // 当玩家输入移动命令时，这个函数被调用
    private void OnMovement(InputValue value)
    {
        // 把玩家的输入转换成一个 2D 向量
        movement = value.Get<Vector2>();

        // 如果玩家正在移动，更新角色的朝向并播放移动动画
        if (movement != Vector2.zero)
        {
            lookDirection = movement;
            animator.SetFloat("x", movement.x);
            animator.SetFloat("y", movement.y);
            animator.SetBool("Run", true); // 设置 "Run" 为 true，开始播放移动动画
        }
        else
        {
            // 如果玩家没有移动，让角色面朝上次移动的方向并播放闲置动画
            animator.SetFloat("x", lookDirection.x);
            animator.SetFloat("y", lookDirection.y);
            animator.SetBool("Run", false); // 设置 "Run" 为 false，开始播放闲置动画
        }
    }

    // FixedUpdate 每秒默认被调用20次，通常用于物理更新
    private void FixedUpdate()
    {
        // 更新角色的位置
        rb.MovePosition(rb.position + movement * playerMoveSpeed);
    }
}
