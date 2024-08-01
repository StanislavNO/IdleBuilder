using UnityEngine;

namespace Assets.Source.CodeBase.Environment
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        [SerializeField] private float _speed;
        [SerializeField][Range(-1, 1)] private int _sideRotation;

        private void Update()
        {
            Rotate();
        }

        private void Rotate()
        {
            float rotation = _sideRotation * _speed * Time.deltaTime;
            _transform.Rotate(Vector3.up, rotation);
        }
    }
}