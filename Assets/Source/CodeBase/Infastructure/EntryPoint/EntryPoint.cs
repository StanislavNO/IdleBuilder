using Agava.YandexGames;
using Assets.Source.CodeBase;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Source.Yandex
{
    public class EntryPoint : MonoBehaviour
    {
        private void Awake()
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            YandexGamesSdk.CallbackLogging = true;
            StartCoroutine(InitSDK());
#else
            OnInitialize();
#endif
        }

        private IEnumerator InitSDK()
        {
            yield return YandexGamesSdk.Initialize(OnInitialize);
        }

        private void OnInitialize()
        {
            SceneManager.LoadScene(SceneNames.Game.ToString());
        }
    }
}