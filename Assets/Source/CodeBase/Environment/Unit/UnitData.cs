using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class UnitData
    {
        private float _speed = 0;

        public UnitData(Transform basePoint, Transform endPoint, Transform unitTransform)
        {
            BasePoint = basePoint;
            EndPoint = endPoint;
            UnitTransform = unitTransform;
        }

        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _speed = value;
            }
        }

        public float OffsetToTarget { get; private set; }
        public Transform BasePoint { get; private set; }
        public Transform EndPoint { get; private set; }
        public Transform UnitTransform { get; private set; }
    }
}