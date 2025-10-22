using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFadeTrigger : MonoBehaviour
{
    public Image fadeImage; // Assign your black Image here
    public float fadeDuration = 2f;

    private bool hasFaded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasFaded && other.CompareTag("Player"))
        {
            StartCoroutine(FadeToBlack());
            hasFaded = true;
        }
    }

    private IEnumerator FadeToBlack()
    {
        float elapsed = 0f;
        Color color = fadeImage.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsed / fadeDuration);
            fadeImage.color = color;
            yield return null;
        }

        color.a = 1f; // Ensure fully black at the end
        fadeImage.color = color;
    }
}
