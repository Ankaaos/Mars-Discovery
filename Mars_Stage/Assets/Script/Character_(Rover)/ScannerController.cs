using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ScannerController : MonoBehaviour
{
    [Header("| Scanner |")]
    [SerializeField] private float _speed;
    [SerializeField] private float _delayDestroy;
    public float DelayDestroy { get => _delayDestroy; set => _delayDestroy = value; }

    [SerializeField] private SphereDetection _sphereDetection;


    // [Header("Script")]
    // [SerializeField] private Shader_Manager _shaderManager;

    private void Start()
    {
        _sphereDetection = GetComponent<SphereDetection>();
        DestroyObject();

        Debug.Log("SphereDetection reference: " + _sphereDetection);

    }



    private void Update()
    {
        Vector3 vectorMesh = this.transform.localScale;
        float growing = this._speed * Time.deltaTime;
        this.transform.localScale = new Vector3(vectorMesh.x + growing, vectorMesh.y + growing, vectorMesh.z + growing);

        // _sphereDetection = GetComponent<SphereDetection>();
        _sphereDetection = FindObjectOfType<SphereDetection>();

        


    }


    public void DestroyObject()
    {
        Destroy(this.gameObject, _delayDestroy);
    }

    public void TriggerSphereDetection()
    {
        if(_sphereDetection == null)
        {
            return;
        }
        _sphereDetection.StartDetection();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _sphereDetection.StartDetection();
    }


}

// private void Awake()
//     {
//         _shaderManager = FindObjectOfType<Shader_Manager>();
//     }

// if (objShaderManager != null)
            //{
                // objShaderManager.StartFadeInCouroutine();
                // _shaderManager._opacity = 1;
                // _shaderManager.UpdateOpcaticy();
                
                // objShaderManager.StartFadeOutCouroutine();
            //}
