using Agava.YandexGames;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerBase _base;

        private GameStateMachine _stateMachine;

        private void Awake()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            OnCallGameReadyButtonClick();
#endif

            _stateMachine = new();
        }

        private void OnCallGameReadyButtonClick()
        {
            YandexGamesSdk.GameReady();
        }
    }
}