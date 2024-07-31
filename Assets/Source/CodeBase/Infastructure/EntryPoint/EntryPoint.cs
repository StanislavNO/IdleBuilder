using Agava.YandexGames;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class EntryPoint : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(InitSDK());
        }

        private IEnumerator InitSDK()
        {
            yield return YandexGamesSdk.Initialize();
            Bootstrap();
        }

        private void Bootstrap()
        {
            throw new NotImplementedException();
        }
    }
}