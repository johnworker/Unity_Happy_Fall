using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class GiftManager : MonoBehaviour
    {
        public UnitBase[] m_Clone = null;

        public Transform m_FruitNode = null;

        public PlayerControl m_Player = null;

        private float m_Delay = 0;
        private int m_TimeRank = 0;
        private float m_AddTime = 10;

        private const float m_MathTime = 10;
        private const int m_BombProBase = 5;

        private void Start()
        {
            m_Delay = Time.time + 1;
            m_AddTime = m_MathTime;
        }

        private void Update()
        {
            if(m_Delay < Time.time)
            {
                m_Delay = Time.time + 1;
                CreateFruit();
            }

            if(m_Player.GetNowTime() < m_AddTime)
            {
                m_TimeRank++;
                m_AddTime += m_MathTime;
            }
        }

        private void CreateFruit()
        {
            UnitBase unit = GetCreateObj();

            UnitBase createUnit = Instantiate<UnitBase>(unit, m_FruitNode);
            createUnit.transform.localPosition = new Vector3(Random.Range(-450f, 450f), 550f, 0);
        }

        private UnitBase GetCreateObj()
        {

            //if (m_TimeRank > 0)
            //{
            //    fruitl = 5;
            //}
            //else
            //{
            //    fruitl = 0;
            //}


            int r = Random.Range(0, 100); // 0-99

            int mathBombPro = m_BombProBase + m_TimeRank;
            int giftl = m_TimeRank > 0 ? 5 : 0;
            int gift2 = m_TimeRank > 1 ? 5 : 0;
            int gift3 = m_TimeRank > 2 ? 5 : 0;
            int gift4 = m_TimeRank > 3 ? 5 : 0;
            int gift5 = m_TimeRank > 4 ? 5 : 0;
            int gift6 = m_TimeRank > 5 ? 5 : 0;
            int gift7 = m_TimeRank > 6 ? 5 : 0;
            int gift8 = m_TimeRank > 7 ? 5 : 0;

            r -= mathBombPro;

            if(r < 0)
            {
                return m_Clone[1];
            }

            r -= giftl;
            if (r < 0)
            {
                return m_Clone[2];
            }

            r -= gift2;
            if (r < 0)
            {
                return m_Clone[3];
            }

            r -= gift3;
            if (r < 0)
            {
                return m_Clone[4];
            }

            r -= gift4;
            if (r < 0)
            {
                return m_Clone[5];
            }

            r -= gift5;
            if (r < 0)
            {
                return m_Clone[6];
            }

            r -= gift6;
            if (r < 0)
            {
                return m_Clone[7];
            }

            r -= gift7;
            if (r < 0)
            {
                return m_Clone[8];
            }

            r -= gift8;
            if (r < 0)
            {
                return m_Clone[9];
            }

            return m_Clone[0];
        }
    }
}
