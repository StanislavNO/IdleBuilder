using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class StopState : MovementState
    {
        private float _speedDelta;
        private float _minSpeed;

        public StopState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _speedDelta = 1f;
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

            if (Data.Speed <= _speedDelta)
                StateSwitcher.SwitchState<WorkState>();
        }

        protected private override float GetSpeed()
        {
            float newSpeed = Mathf.Lerp(
                Data.Speed, _minSpeed, _speedDelta * Time.deltaTime);
            Debug.Log("Stopping" + Data.Speed);

            return newSpeed;
        }
    }
}