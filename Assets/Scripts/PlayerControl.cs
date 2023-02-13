using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class PlayerControl : MonoBehaviour
    {

        public int m_ScoreValue = 0;

        void Start()
        {

        }

        public void AddScore(int add)
        {
            m_ScoreValue += add;
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localPosition += new Vector3(-300, 0, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localPosition += new Vector3(300, 0, 0) * Time.deltaTime;
            }

        }
    }

}
