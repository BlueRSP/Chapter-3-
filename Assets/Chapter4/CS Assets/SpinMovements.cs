using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Panyawut.GameDev3.Chapter4
{
    public class SpinMovements : MonoBehaviour
    {
        [SerializeField] private float _angularSpeed = 5.0f;

        [SerializeField] private Vector3 _axisOfRotation = new Vector3(1.0f, 0, 0);

        private Transform _objTransformComponent;

        void Start()
        {
            _objTransformComponent = this.gameObject.GetComponent<Transform>();
        }

        void Update()
        {
            _objTransformComponent.Rotate(_axisOfRotation, _angularSpeed);
        }
    }
}
