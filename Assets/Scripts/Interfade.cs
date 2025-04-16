using UnityEngine;
using NaughtyAttributes;

public class Interface : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup; 
    [SerializeField] private float _fadeSpeed = 1f;

    private bool _isShown = false;  

    [Button("Toggle UI")]
    public void ToggleUI()
    {
        _isShown = !_isShown;  
        _canvasGroup.Fade(_isShown, _fadeSpeed);  
    }
}
