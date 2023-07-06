using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shader_Manager : MonoBehaviour
{
    [Header("| Outline |")]
    [SerializeField] private Material _mat;
    private float _matF;
    public float _opacity;

    private void Start()
    {   
        _opacity = 0;
        UpdateOpcaticy();
    }

    private void Update()
    {
        UpdateOpcaticy();
    }

    public void UpdateOpcaticy()
    {
        _mat.SetFloat("_Opacity", _opacity);

    }

}
