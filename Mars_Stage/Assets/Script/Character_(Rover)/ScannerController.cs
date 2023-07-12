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

    private void Start()
    {
        _sphereDetection = GetComponent<SphereDetection>();
        DestroyObject();
    }

    private void Update()
    {
        Vector3 vectorMesh = this.transform.localScale;
        float growing = this._speed * Time.deltaTime;
        this.transform.localScale = new Vector3(vectorMesh.x + growing, vectorMesh.y + growing, vectorMesh.z + growing);

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
