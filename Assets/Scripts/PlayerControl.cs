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

        public Transform m_BagObj = null;

        private bool m_IsGameOver = false;

        void Start()
        {
            Refresh();
        }

        void Update()
        {
            if (m_IsGameOver)
            {
                return;
            }

            m_TimeValue += Time.deltaTime;
            m_Time.text = "時間" + m_TimeValue.ToString("0.0");

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localPosition += new Vector3(-300, 0, 0) * Time.deltaTime;
                m_BagObj.localPosition = new Vector3(-100, 30, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localPosition += new Vector3(300, 0, 0) * Time.deltaTime;
                m_BagObj.localPosition = new Vector3(100, 30, 0);
            }

        }

        public void Die()
        {
            Time.timeScale = 0;
            m_IsGameOver = true;
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
