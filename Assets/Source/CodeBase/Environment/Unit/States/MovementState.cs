using UnityEngine;

namespace Assets.Source.CodeBase
{
    public abstract class MovementState : IUnitState , IState
    {
        private readonly Transform _transform;

        public MovementState(IStateSwitcher stateSwitcher, UnitData data)
        {
            StateSwitcher = stateSwitcher;
            OffsetToTarget = data.OffsetToTarget;
            Data = data;
            _transform = Data.UnitTransform;
            Target = Data.BasePoint;
        }

        protected IStateSwitcher StateSwitcher { get; private set; }
        protected float OffsetToTarget { get; private set; }
        protected UnitData Data { get; private set; }
        protected Vector3 Position => _transform.position;
        protected Transform Target { get; private set; }

        public virtual void Update() => Move();

        public abstract void Enter();
        
        public abstract void Exit();

        protected void SetTarget(Transform target) => Target = target;

        private void Move()
        {
            _transform.position = Vector3.MoveTowards(
                _transform.position, Target.position, Data.Speed * Time.deltaTime);
        }
    }
}
