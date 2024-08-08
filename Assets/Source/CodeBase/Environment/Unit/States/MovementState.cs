using UnityEngine;

namespace Assets.Source.CodeBase
{
    public abstract class MovementState : IState
    {
        private readonly Transform _transform;

        public MovementState(IStateSwitcher stateSwitcher, UnitData data)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            _transform = Data.UnitTransform;
            Data.Target = Data.BasePoint;
        }

        protected IStateSwitcher StateSwitcher { get; private set; }
        protected UnitData Data { get; private set; }
        protected Vector3 Position => _transform.position;

        public virtual void Update() => Move();

        public abstract void Enter();
        
        public abstract void Exit();

        protected void SetTarget(Transform target)
        {
            Data.Target = target;
            Debug.Log("SetTarget " + Data.Target.position);
        }

        private void Move()
        {
            //Debug.Log("Move " + Data.Target.position);
            _transform.position = Vector3.MoveTowards(
                _transform.position, Data.Target.position, Data.Speed * Time.deltaTime);
        }
    }
}
