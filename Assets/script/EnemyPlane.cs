using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{
    public float MoveSpeed = 1f; // 敵機的速度設定值

    void Update()
    {
        // 使用Update来处理敌机移动
        transform.Translate(Vector3.down * MoveSpeed * Time.deltaTime);

        // 如果敌机移出屏幕范围，销毁自身
        if (transform.position.y < -6)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 子弹碰撞检测
        if (collision.tag == "Bullet")
        {
            Debug.Log("Collision detected with Bullet");
            Destroy(gameObject); // 销毁敌机
            Destroy(collision.gameObject); // 销毁子弹
        }
    }
}
