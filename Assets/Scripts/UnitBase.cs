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
        public Rigidbody m_Rigidbody = null;

        private int m_ScaleValue = 1;
        public int m_ScoreBase = 1;

        private void Start()
        {
            RefreshScale();
        }

        private void RefreshScale()
        {
            m_ScaleText.text = "x" + m_ScaleValue;
        }

        private void OnCollisionEnter(Collision collision)
        {
            PlayerControl pc = collision.transform.parent.GetComponent<PlayerControl>();
            if (pc != null)
            {
                if(collision.gameObject.name == "Bag")
                {
                    pc.AddScore(m_ScoreBase * m_ScaleValue);
                    Destroy(gameObject);
                }
                else if (collision.gameObject.name == "Head")
                {
                    // Vector2 v = m_Rigidbody.velocity;
                    // 取得速度的幅度
                    // float magn = m_Rigidbody.velocity.magnitude;

                    // 取得速度的單位向量
                    Vector2 v = m_Rigidbody.velocity.normalized;
                    m_Rigidbody.velocity = v * 50;
                    m_ScaleValue++;
                    RefreshScale();
                }
            }
        }
    }

}
