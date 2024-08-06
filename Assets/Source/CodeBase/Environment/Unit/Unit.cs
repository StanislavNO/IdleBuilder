using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    [RequireComponent(typeof(Collider))]
    public class Unit : MonoBehaviour, IUnit
    {
        private UnitStateMachine _stateMachine;
        private IStateSwitcher _stateSwitcher;

        private void Update()
        {
            _stateMachine?.Update();
        }

        private void OnTriggerEnter(Collider other)
        {
            _stateSwitcher.Switch<StopState>();
        }

        private void OnTriggerExit(Collider other)
        {
            _stateSwitcher.Switch<MoveState>();
        }
    }
}