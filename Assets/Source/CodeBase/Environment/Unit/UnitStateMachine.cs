using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class UnitStateMachine : IStateSwitcher
    {
        private List<IUnitState> _states;

        private IUnitState _currentState;

        public UnitStateMachine(UnitData unitData, Transform resource)
        {
            _states = new List<IUnitState>()
            {
                new MoveState(this, unitData),
                new WorkState(resource ,this, unitData),
                new StopState(this, unitData),
                new ReapedState(this, unitData)
            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void Update()
        {
            _currentState.Update();
        }

        public void SwitchState<T>() where T : IState
        {
            IUnitState state = _states.FirstOrDefault(state => state is T);

            _currentState?.Exit();
            _currentState = state;
            _currentState.Enter();
        }
    }
}
