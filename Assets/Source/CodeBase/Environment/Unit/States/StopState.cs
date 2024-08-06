using System;
using UnityEngine;
using System.Numerics;
using Unity.VisualScripting;

namespace Assets.Source.CodeBase
{
    public class StopState : MovementState, IState
    {
        private float _maxDelta;
        private float _stopSpeed;

        public StopState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _maxDelta = 0.1f;
            _stopSpeed = 0;
        }

        public void Enter()
        {
        }

        public void Exit()
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
                Data.Speed, _stopSpeed, _maxDelta * Time.deltaTime);

            Data.Speed = newSpeed;
        }
    }
}