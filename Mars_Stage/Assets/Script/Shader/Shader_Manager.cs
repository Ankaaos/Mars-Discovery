using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader_Manager : MonoBehaviour
{
    [Header("| Outline |")]
    [SerializeField] private Material _mat;


    public float _opacity;

    [Header("Script")]
    [SerializeField] private ScannerController _scanControl;

    private void Awake()
    {
    }


    private void Start()
    {
        _opacity = 0;
        UpdateOpcaticy();
    }

    private void Update()
    {
        _scanControl = FindObjectOfType<ScannerController>();

        UpdateOpcaticy();
        if(_scanControl == null)
        {
            return;
        }
        
        _scanControl.TriggerSphereDetection();



    }

    public void UpdateOpcaticy()
    {
        _mat.SetFloat("_Opacity", _opacity);

    }


}

// [SerializeField] private float _fadeOutDuration = 3f;
// [SerializeField] private float _fadeInDuration = 1f;

// private float _matF;
// private float _elapsedTime = 0f;

//-----------------------------------------------------------

//public void StartFadeInCouroutine()
// {
//     StartCoroutine(FadeIn());
// }

// IEnumerator FadeIn()
// {
//     float _startOpacity = 0f;

//     while (_elapsedTime < _fadeInDuration)
//     {
//         _elapsedTime += Time.deltaTime;
//         float t = Mathf.Clamp01(_elapsedTime / _fadeInDuration);
//         _opacity = Mathf.Lerp(_startOpacity, 1f, t);

//         yield return null;
//     }

//     _opacity = 1;
//     UpdateOpcaticy();


// }


// public void StartFadeOutCouroutine()
// {
//     StartCoroutine(FadeOut());
// }

// IEnumerator FadeOut()
// {
//     // yield return new WaitForSeconds(_scanControl.DelayDestroy);


//     float _startOpacity = _opacity;

//     while (_elapsedTime < _fadeOutDuration)
//     {
//         _elapsedTime += Time.deltaTime;
//         float t = Mathf.Clamp01(_elapsedTime / _fadeOutDuration);
//         _opacity = Mathf.Lerp(_startOpacity, 0f, t);


//         yield return null;
//     }


//     _opacity = 0;
//     UpdateOpcaticy();

// }
