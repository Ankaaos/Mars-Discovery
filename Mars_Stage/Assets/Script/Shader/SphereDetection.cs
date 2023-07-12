
using UnityEngine;

public class SphereDetection : MonoBehaviour
{
    [SerializeField] private float sphereRadius = 1f;
    [SerializeField] private LayerMask detectionLayer;
    [SerializeField] private Material _mat;

    [SerializeField] private Shader_Manager _shaderManager;


    private void Awake()
    {
        _shaderManager = GetComponent<Shader_Manager>();
        

    }

    private void Start()
    {
        _shaderManager = FindObjectOfType<Shader_Manager>();
    }
    public void StartDetection()
    {
        // Créez une sphère de rayonnement
        Vector3 center = transform.position;
        float radius = transform.localScale.x * sphereRadius; // Utilisez la valeur de localScale pour ajuster le rayon de la sphère
        Vector3 direction = transform.forward;
        float maxDistance = Mathf.Infinity;

        // Effectuez le SphereCastAll
        RaycastHit[] hits = Physics.SphereCastAll(center, radius, direction, maxDistance, detectionLayer);

        // Parcourez les résultats du SphereCastAll
        for (int i = 0; i < hits.Length; i++)
        {
            // Destroy(hits[i].collider.gameObject);

            Renderer renderer = hits[i].collider.GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.material = _mat;
                _shaderManager.SetOpacityForMaterial(renderer.material, 1f);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, transform.localScale.x * sphereRadius);
    }
}

