using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ScannerController : MonoBehaviour
{
    [Header("| Scanner |")]
    [SerializeField] private float _speed;
    [SerializeField] private float _delayDestroy;
    public bool _destroy = false;

    [Header("Script")]
    [SerializeField] private Shader_Manager _shaderManager;




    private void Awake()
    {
        _shaderManager = FindObjectOfType<Shader_Manager>();

    }

    private void Start()
    {
        DestroyObject();
    }

    private void Update()
    {
        Vector3 vectorMesh = this.transform.localScale;
        float growing = this._speed * Time.deltaTime;
        this.transform.localScale = new Vector3(vectorMesh.x + growing, vectorMesh.y + growing, vectorMesh.z + growing);

        Debug.Log(_delayDestroy);


    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Rock"))
        {
            _shaderManager._opacity = 1;
            _destroy = true;

        }

    }


    public void DestroyObject()
    {
        
        Destroy(this.gameObject, _delayDestroy);

    }


}
