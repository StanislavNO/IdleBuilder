using Agava.YandexGames;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private BaseUpdater _base;

        private GameStateMachine _stateMachine;

        private void Awake()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            OnCallGameReadyButtonClick();
#endif

            _stateMachine = new();

            _base.Init(0);
        }

        private void OnCallGameReadyButtonClick()
        {
            YandexGamesSdk.GameReady();
        }
    }
}