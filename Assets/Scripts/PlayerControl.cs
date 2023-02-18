using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace monster
{
    public class PlayerControl : MonoBehaviour
    {

        public int m_ScoreValue = 0;
        public float m_TimeValue = 0;

        public TextMeshProUGUI m_Score = null;
        public TextMeshProUGUI m_Time = null;

        void Start()
        {
            Refresh();
        }

        void Update()
        {
            m_TimeValue += Time.deltaTime;
            m_Time.text = "時間" + m_TimeValue.ToString("0.0");

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localPosition += new Vector3(-300, 0, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localPosition += new Vector3(300, 0, 0) * Time.deltaTime;
            }

        }

        public void AddScore(int add)
        {
            m_ScoreValue += add;
            Refresh();
        }

        private void Refresh()
        {
            m_Score.text = "分數:" + m_ScoreValue;
        }

    }

}
