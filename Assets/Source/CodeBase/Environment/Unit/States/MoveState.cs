using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class MoveState : MovementState
    {
        private readonly Transform _basePoint;
        private readonly Transform _endPoint;

        public MoveState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _basePoint = data.BasePoint;
            _endPoint = data.EndPoint;
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

            if (TryTouchToTarget())
            {
                if (Target == _basePoint)
                {
                    SetTarget(_endPoint);
                    StateSwitcher.SwitchState<WorkState>();
                }
                else if (Target == _endPoint)
                    StateSwitcher.SwitchState<ReapedState>();
            }

            AddSpeed();
        }

        private void AddSpeed()
        {
            float speedDelta = 1;
            float newSpeed = Mathf.MoveTowards(
                Data.Speed, Data.MaxSpeed, speedDelta);

            Data.Speed = newSpeed;
        }

        private bool TryTouchToTarget()
        {
            float distance = (Target.position - Position).magnitude;

            if (distance < OffsetToTarget)
                return true;

            return false;
        }
    }
}
