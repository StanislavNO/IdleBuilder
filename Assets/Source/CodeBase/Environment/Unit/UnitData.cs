using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public sealed class UnitData
    {
        private float _speed = 0;
        private Transform _target;

        public UnitData(Transform basePoint, Transform endPoint, Transform unitTransform)
        {
            StartPosition = unitTransform.position;
            BasePoint = basePoint;
            EndPoint = endPoint;
            UnitTransform = unitTransform;
            OffsetToTarget = 20f;
            MaxSpeed = 37;
            _target = basePoint;
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

        public Transform Target 
        { 
            get => _target;
            set
            {
                if (_target == null)
                    throw new ArgumentNullException(nameof(value));

                _target = value;
            } 
        }

        public Vector3 StartPosition { get; private set; }
        public float MaxSpeed { get; private set; }
        public float OffsetToTarget { get; private set; }
        public Transform BasePoint { get; private set; }
        public Transform EndPoint { get; private set; }
        public Transform UnitTransform { get; private set; }
    }
}