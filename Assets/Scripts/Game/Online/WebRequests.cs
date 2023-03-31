using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Networking;


public static class WebRequests
{
    private class WebRequestMonoBehaviour : MonoBehaviour { }

    private static WebRequestMonoBehaviour webRequestMonoBehaviour;

    private static void Init()
    {
        if (webRequestMonoBehaviour == null)
        {
            GameObject gameObject = new GameObject("WebRequests");
            webRequestMonoBehaviour = gameObject.AddComponent<WebRequestMonoBehaviour>();
        }
    }
    public static void Get(string url1, string url2, Action<string> onError, Action<string> onSuccess)
    {
        Init();
        webRequestMonoBehaviour.StartCoroutine(GetCoroutine(url1, url2, onError, onSuccess));
    }

    public static void GetSprite1(string url1, string url2, Action<string> onError, Action<Texture2D> onSuccess)
    {
        Init();
        webRequestMonoBehaviour.StartCoroutine(GetSprite1Coroutine(url1, url2, onError, onSuccess));
    }

    public static void GetSprite2(string url1, string url2, Action<string> onError, Action<Texture2D> onSuccess)
    {
        webRequestMonoBehaviour.StartCoroutine(GetSprite2Coroutine(url1, url2, onError, onSuccess));
    }


    private static IEnumerator GetCoroutine(string url1, string url2, Action<string> onError, Action<string> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequest.Get(url1))
        {
            yield return unityWebRequest.SendWebRequest();
            if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError || unityWebRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                onError(unityWebRequest.error);
            }
            else
            {
                onSuccess(unityWebRequest.downloadHandler.text);
            }
        }
    }

    private static IEnumerator GetSprite1Coroutine(string url1, string url2, Action<string> onError, Action<Texture2D> onSuccess)
    {
        using (UnityWebRequest unityWebRequest = UnityWebRequestTexture.GetTexture(url1))
        {
            yield return unityWebRequest.SendWebRequest();
            if (unityWebRequest.result == UnityWebRequest.Result.ConnectionError || unityWebRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                onError(unityWebRequest.error);
            }
            else
            {
                DownloadHandlerTexture downloadHandlerTexture = unityWebRequest.downloadHandler as DownloadHandlerTexture;
                onSuccess(downloadHandlerTexture.texture);
            }
        }
    }

    public static IEnumerator GetSprite2Coroutine(string url1, string url2, Action<string> onError, Action<Texture2D> onSuccess)
    {
        using (UnityWebRequest unityWebRequest2 = UnityWebRequestTexture.GetTexture(url2))
        {
            yield return unityWebRequest2.SendWebRequest();
            if (unityWebRequest2.result == UnityWebRequest.Result.ConnectionError || unityWebRequest2.result == UnityWebRequest.Result.ProtocolError)
            {
                onError(unityWebRequest2.error);
            }
            else
            {
                DownloadHandlerTexture downloadHandlerTexture = unityWebRequest2.downloadHandler as DownloadHandlerTexture;
                onSuccess(downloadHandlerTexture.texture);
            }
        }
    }


}
