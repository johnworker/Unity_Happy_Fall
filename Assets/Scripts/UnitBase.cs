using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace monster
{
    public class UnitBase : MonoBehaviour
    {
        public TextMeshProUGUI m_ScaleText = null;
        public int m_ScaleValue = 0;
        public Rigidbody m_Rigidbody = null;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerControl pc = collision.transform.parent.GetComponent<PlayerControl>();
            if (pc != null)
            {
                if(collision.gameObject.name == "Bag")
                {

                }
                else if (collision.gameObject.name == "Head")
                {
                    // Vector2 v = m_Rigidbody.velocity;
                    // 取得速度的幅度
                    float magn = m_Rigidbody.velocity.magnitude;
                    // 取得速度的單位向量
                    Vector2 v = m_Rigidbody.velocity.normalized;
                }
            }
        }
    }

}
