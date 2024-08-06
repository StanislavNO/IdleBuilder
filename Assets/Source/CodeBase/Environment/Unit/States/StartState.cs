namespace Assets.Source.CodeBase
{
    public class StartState : MoveState, IState
    {
        public StartState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {

        }
    }
}