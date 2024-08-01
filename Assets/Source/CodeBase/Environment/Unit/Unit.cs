using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class Unit : MonoBehaviour, IUnit
    {
        private List<IUnitState> _unitStates;

        private IUnitState _currentState;

        private void Awake()
        {
            CreateStates();
        }

        public Transform Target { get; private set; }

        private void Update()
        {
            if (_currentState == null)
                return;

            _currentState.Update(this);
        }

        public void GoToNextState()
        {
            if (_currentState == null || _unitStates == null) 
                return;

        }

        private void CreateStates()
        {
            _unitStates = new List<IUnitState>()
            {

            };
        }
    }
}