using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class StopState : MovementState
    {
        private float _maxDelta;
        private float _minSpeed;

        public StopState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _maxDelta = 1f;
            _minSpeed = 0;
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
                Data.Speed, _minSpeed, _maxDelta);

            Data.Speed = newSpeed;

            if (Data.Speed <= _minSpeed)
                StateSwitcher.SwitchState<WorkState>();
        }
    }
}