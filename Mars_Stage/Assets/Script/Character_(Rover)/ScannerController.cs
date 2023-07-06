using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerController : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float _speed;

    [Header("Destroy Time")]
    [SerializeField] private float _delayDestroy;

    private void Start()
    {
        DestroyObject();
    }

    private void Update()
    {
        Vector3 vectorMesh = this.transform.localScale;
        float growing = this._speed * Time.deltaTime;
        this.transform.localScale = new Vector3(vectorMesh.x + growing, vectorMesh.y + growing, vectorMesh.z + growing);
    }

    private void OnTriggerEnter(Collider col)
    {   
        if(col.gameObject.CompareTag("Rock"))
        {
            Debug.Log("Rock colision");
        }
    }

    public void DestroyObject()
    {
        Destroy(this.gameObject, _delayDestroy);
    }
}
