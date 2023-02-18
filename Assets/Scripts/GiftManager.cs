using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class GiftManager : MonoBehaviour
    {
        public UnitBase m_Clone = null;

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
            UnitBase unit = Instantiate<UnitBase>(m_Clone, m_FruitNode);
            unit.transform.localPosition = new Vector3(Random.Range(-450f, 450f), 550f, 0);
        }
    }

}
