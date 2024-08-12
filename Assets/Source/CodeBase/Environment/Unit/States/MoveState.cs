using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class MoveState : MovementState
    {
        public MoveState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
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
                //Debug.Log("TryTouch");

                if (Data.Target == Data.EndPoint)
                {
                    StateSwitcher.SwitchState<ReapedState>();
                }
                else if (Data.Target == Data.BasePoint)
                {
                    //Debug.Log("TargetBase");
                    StateSwitcher.SwitchState<StopState>();
                }
            }

            //AddSpeed();
        }

        protected private override float GetSpeed()
        {
            Debug.Log("AddSpeed" + Data.Speed + " Target" + Data.Target.position);
            float speedDelta = 0.1f;
            float newSpeed = Mathf.Lerp(
                Data.Speed, Data.MaxSpeed, speedDelta * Time.deltaTime);

            return newSpeed;
        }

        private bool TryTouchToTarget()
        {
            float distance = (Data.Target.position - Position).magnitude;
            Debug.Log("distance = " + distance);

            if (distance < Data.OffsetToTarget)
                return true;

            return false;
        }
    }
}
