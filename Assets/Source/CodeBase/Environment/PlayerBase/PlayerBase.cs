using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class PlayerBase : MonoBehaviour
    {
        [SerializeField] private BaseView _view;
        [SerializeField] private List<GameObject> _models;

        public void Init(int level)
        {
            if(level < 0)
                throw new ArgumentOutOfRangeException(nameof(level));

            Level = level;

            DisableModels();
            EnableModel(Level);
        }

        public int Level { get; private set; }

        private void EnableModel(int index) =>
            _models[index].SetActive(true);

        private void DisableModels()
        {
            foreach (var model in _models)
                model.SetActive(false);
        }
    }
}