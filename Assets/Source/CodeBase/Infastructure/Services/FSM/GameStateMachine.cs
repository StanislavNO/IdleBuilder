using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public class GameStateMachine : IStateSwitcher
    {
        private readonly List<IState> _states;

        private IState _currentState;

        public GameStateMachine()
        {
            _states = new List<IState>()
            {

            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void Switch<T>() where T : IState
        {
            throw new NotImplementedException();
        }
    }
}
