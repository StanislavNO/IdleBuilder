using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    [RequireComponent(typeof(Collider))]
    public class Unit : MonoBehaviour, IUnit
    {
        [SerializeField] ResourceMarker resource;

        private UnitStateMachine _stateMachine;
        private IStateSwitcher _stateSwitcher;

        public void Init(UnitData unitData)
        {
            _stateMachine = new(unitData, resource.transform);
        }

        private void Update()
        {
            _stateMachine?.Update();
        }

        private void OnTriggerEnter(Collider other)
        {
            _stateSwitcher.SwitchState<StopState>();
        }

        private void OnTriggerExit(Collider other)
        {
            _stateSwitcher.SwitchState<MoveState>();
        }
    }
}