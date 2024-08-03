using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public class UnitStateMachine
    {
        private List<IUnitState> _unitStates;

        private IUnitState _currentState;

        public UnitStateMachine()
        {
            _unitStates = new List<IUnitState>()
            {
                //new UnitMoveState(),
                //new UnitWorkState(),
                //new UnitResetState()
            };
        }
    }
}
