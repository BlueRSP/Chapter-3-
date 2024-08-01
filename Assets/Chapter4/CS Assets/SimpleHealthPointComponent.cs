using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Panyawut.GameDev3.Chapter1
{
    public class SimpleHealthPointComponent : MonoBehaviour
    {
        [SerializeField]
        public const float MAX_HP = 100;

        [SerializeField] 
        private float m_HealthPoint;

        public float HealthPoint
        {
            get
            {
                return m_HealthPoint;
            }
            set
            {
                m_HealthPoint = value;
                //if (value > 0)
                //{
                //if (value <= MAX_HP)
                //{
                //m_HealthPoint = value;
                //}
                //else
                //{
                //m_HealthPoint = MAX_HP;
                //}
                //}
            }
        }
    }
}