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
            PlayerControl pc = collision.gameObject.transform.parent.GetComponent<PlayerControl>();
        }
    }

}
