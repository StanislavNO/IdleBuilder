using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class BaseUpdater : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _baseModules;

        private int _maxLevel;

        public void Init(int level)
        {
            if(level < 0)
                throw new ArgumentOutOfRangeException(nameof(level));

            Level = level;
            _maxLevel = 7;

            DisableModels();
            EnableModel(Level);
        }

        public int Level { get; private set; }

        public void LevelUp()
        {
            if(Level == _maxLevel)
                return;

            Level++;
            EnableModel(Level);
        }

        private void EnableModel(int index)
        {
            if(index < _baseModules.Count && index >= 0)
                _baseModules[index].SetActive(true);
        }

        private void DisableModels()
        {
            foreach (var model in _baseModules)
                model.SetActive(false);
        }
    }
}