using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class BombUnit : UnitBase
    {

        public override void OnCollisionEnter(Collision collision)
        {
            PlayerControl pc = collision.transform.parent.GetComponent<PlayerControl>();
            if (pc != null)
            {
                if (collision.gameObject.name == "Bag")
                {
                    pc.Die();
                    Destroy(gameObject);
                }
                else if (collision.gameObject.name == "Head")
                {
                    // Vector2 v = m_Rigidbody.velocity;
                    // 取得速度的幅度
                    // float magn = m_Rigidbody.velocity.magnitude;

                    // 取得速度的單位向量
                    Vector3 v = m_Rigidbody.velocity.normalized;
                    m_Rigidbody.velocity = v * 50;
                }
            }
        }

    }
}
