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
            Data.Speed = 0;
        }

        public override void Exit()
        {
            Debug.Log("Exit Work");
            SetTarget(Data.EndPoint);
            _resource.gameObject.SetActive(false);
            _resource.transform.localScale = _startResourceScale;
            Debug.Log(Data.Target.position);
        }

        public override void Update()
        {
            base.Update();

            HideResource();

            if (_resource.transform.localScale.magnitude <= 0.1f)
                StateSwitcher.SwitchState<MoveState>();
        }

        private void HideResource()
        {
            Vector3 newScale = Vector3.Lerp(_resource.transform.localScale, Vector3.zero, 1f * Time.deltaTime); 
            _resource.transform.localScale = newScale;
        }
    }
}