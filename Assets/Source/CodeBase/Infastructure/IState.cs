namespace Assets.Source.CodeBase
{
    public interface IState : ITickable
    {
        void Enter();
        void Exit();
    }
}
