using System;
using UnityEngine;
using System.Numerics;
using Unity.VisualScripting;

namespace Assets.Source.CodeBase
{
    public class StopState : MovementState
    {
        private float _maxDelta;
        private float _stopSpeed;

        public StopState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _maxDelta = 0.1f;
            _stopSpeed = 0;
        }

        public override void Enter()
        {
        }

        public override void Exit()
        {
        }

        public override void Update()
        {
            base.Update();

            Stopping();
        }

        private void Stopping()
        {
            float newSpeed = Mathf.MoveTowards(
                Data.Speed, _stopSpeed, _maxDelta);

            Data.Speed = newSpeed;
        }
    }
}