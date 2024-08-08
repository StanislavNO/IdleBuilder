namespace Assets.Source.CodeBase
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}
