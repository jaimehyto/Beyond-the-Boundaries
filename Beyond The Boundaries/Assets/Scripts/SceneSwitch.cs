using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{
    CanvasGroup canvasGroup;
    [SerializeField] float fadeTime = 3f;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        StartCoroutine(EnterFadeCanvasGroup());
    }

    void Start()
    {

    }

    void Update()
    {

    }

    private IEnumerator EnterFadeCanvasGroup()
    {
        float start = Time.time;
        float end = start + fadeTime;
        while (Time.time < end)
        {
            canvasGroup.alpha = Mathf.InverseLerp(end, start, Time.time);
            yield return null;
        }
        canvasGroup.alpha = 0;
    }
}
