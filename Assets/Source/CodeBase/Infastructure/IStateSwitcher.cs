using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}
