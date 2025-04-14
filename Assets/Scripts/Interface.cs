using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup; 
    [SerializeField] private float _fadeSpeed = 1f;

    private bool _isShown;

    private IEnumerator Fade()
    {
        float alpha = _isShown ? 0f : 1f;

        if (_isShown)
        {
            while (alpha < 1f)
            {
                alpha += _fadeSpeed * Time.deltaTime;
                _canvasGroup.alpha = alpha;
                yield return null;
            }
        }
        else
        {
            while (alpha > 0f)
            {
                alpha -= _fadeSpeed * Time.deltaTime;
                _canvasGroup.alpha = alpha;
                yield return null;
            }
        }

        yield return new WaitForSeconds(0.5f); 
        Debug.Log("Hello World");
    }

    [ContextMenu("Toggle Ui")] 
    public void ToggleUI()
    {
        _isShown = !_isShown;
        StopAllCoroutines(); 
        StartCoroutine(Fade());
    }
}
