using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField] private Units _unitName;
        [SerializeField][Range(0, 10)] private float _delay;

        [SerializeField] Transform _basePoint;
        [SerializeField] Transform _endPoint;

        private UnitPool _pool;

        public void Init(UnitPool pool)
        {
            _pool = pool;
        }

        private void Start()
        {
            Spawn();
        }

        public void Spawn()
        {
            
        }
    }
}