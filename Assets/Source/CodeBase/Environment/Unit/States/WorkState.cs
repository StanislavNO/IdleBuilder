using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class WorkState : MovementState
    {
        private readonly Transform _resource;
        private readonly Vector3 _startResourceScale;

        public WorkState(Transform resource, IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {
            _resource = resource;
            _startResourceScale = resource.localScale;
        }

        public override void Enter()
        {
            Debug.Log("WorkState");
            HideResource();
        }

        public override void Exit()
        {
            Debug.Log("Exit Work");
            SetTarget(Data.EndPoint);
            Debug.Log(Data.Target.position);
        }

        public override void Update()
        {
            base.Update();


        }

        private void HideResource()
        {
            _resource.gameObject.SetActive(false);
            StateSwitcher.SwitchState<MoveState>();
        }
    }
}