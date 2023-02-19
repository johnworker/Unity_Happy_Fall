using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class GiftManager : MonoBehaviour
    {
        public UnitBase[] m_Clone = null;

        public Transform m_FruitNode = null;

        private float m_Delay = 0;

        private void Start()
        {
            m_Delay = Time.time + 1;
        }

        private void Update()
        {
            if(m_Delay < Time.time)
            {
                m_Delay = Time.time + 1;
                CreateFruit();
            }
        }

        private void CreateFruit()
        {
            int r = Random.Range(0, 10); // 0-9
            UnitBase unit = null;
            if(r < 1)
            {
                unit = m_Clone[1];
            }
            else
            {
                unit = m_Clone[0];
            }

            UnitBase createUnit = Instantiate<UnitBase>(unit, m_FruitNode);
            createUnit.transform.localPosition = new Vector3(Random.Range(-450f, 450f), 550f, 0);
        }
    }

}
