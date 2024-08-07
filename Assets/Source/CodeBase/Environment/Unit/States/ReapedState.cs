namespace Assets.Source.CodeBase
{
    public class ReapedState : MovementState
    {
        public ReapedState(IStateSwitcher stateSwitcher, UnitData data) : base(stateSwitcher, data)
        {

        }

        public override void Enter()
        {
            Data.Speed = 0;
        }

        public override void Exit()
        {
        }
    }
}