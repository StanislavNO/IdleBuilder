using System;
using UnityEngine;

namespace Assets.Source.Code_base
{
    public class UnitView : MonoBehaviour
    {
        private const string IsRunning = "IsRunning";
        private const string IsWork = "IsWork";

        [SerializeField] private Animator _animator;
        //[SerializeField] private EnemyAudioController _audioController;

        //public void Starting() =>
        //    _audioController.PlayStart();

        public void Stopping() { }

        public void StartMoving() =>
            _animator.SetBool(IsRunning, true);

        public void StopMoving() =>
            _animator.SetBool(IsRunning, false);

        public void StartWork() =>
            _animator.SetBool(IsWork, true);

        public void StopWork() =>
            _animator.SetBool(IsWork, false);
    }
}