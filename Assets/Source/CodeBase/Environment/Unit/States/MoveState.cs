using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class MoveState : MovementState, IState
    {
        private readonly Transform _basePoint;
        private readonly Transform _endPoint;

        private Transform _target;

        public MoveState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _basePoint = data.BasePoint;
            _endPoint = data.EndPoint;

            _target = _basePoint;
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            base.Update();

            if (TryTouchToTarget())
            {
                if (_target == _basePoint)
                {
                    _target = _endPoint;
                    StateSwitcher.Switch<WorkState>();
                }
                else if (_target == _endPoint)
                    StateSwitcher.Switch<StartState>();
            }

        }

        private void SwitchTarget(Transform target)
        {
            _target = target;
        }

        private bool TryTouchToTarget()
        {
            float distance = (_target.position - Transform.position).magnitude;

            if (distance < OffsetToTarget)
                return true;

            return false;
        }
    }
}
