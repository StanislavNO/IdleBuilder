using UnityEngine;

namespace Assets.Source.CodeBase
{
    public abstract class MovementState : IUnitState
    {
        public MovementState(IStateSwitcher stateSwitcher, UnitData data)
        {
            StateSwitcher = stateSwitcher;
            OffsetToTarget = data.OffsetToTarget;
            Data = data;
            Transform = data.UnitTransform;
        }

        protected IStateSwitcher StateSwitcher { get; private set; }
        protected float OffsetToTarget { get; private set; }
        protected UnitData Data { get; private set; }
        protected Transform Transform { get; private set; }

        public virtual void Update()
        {
        }
    }
}
