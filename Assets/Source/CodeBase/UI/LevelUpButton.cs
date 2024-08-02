using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Source.CodeBase
{
    public class LevelUpButton : MonoBehaviour
    {
        public Button Button;
        [SerializeField] private BaseUpdater _base;

        private void Awake()
        {
            Button.onClick.AddListener(LevelUp);
        }

        private void LevelUp()
        {
            _base.LevelUp();
        }
    }
}