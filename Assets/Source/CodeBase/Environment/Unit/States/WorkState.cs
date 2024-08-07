using UnityEngine;
using Unity.Jobs;

namespace Assets.Source.CodeBase
{
    public class WorkState : MovementState
    {
        private readonly Transform _resource;
        private readonly Vector3 _startResourceScale;

        public WorkState(Transform resource ,IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _resource = resource;
            _startResourceScale = resource.localScale;
        }

        public override void Enter()
        {
            HideResource(Exit);
        }

        public override void Exit()
        {
            StateSwitcher.SwitchState<MoveState>();
        }

        public override void Update()
        {
            base.Update();


        }

        private void HideResource(System.Action exit)
        {


            _resource.gameObject.SetActive(false);
            exit.Invoke();
        }
    }
}