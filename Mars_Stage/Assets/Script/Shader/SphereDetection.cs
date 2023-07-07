
using UnityEngine;

public class SphereDetection : MonoBehaviour
{
    [SerializeField] private float sphereRadius = 1f;
    [SerializeField] private LayerMask detectionLayer;

    private Shader_Manager _shaderManager;


    private void Awake()
    {
        _shaderManager = GetComponent<Shader_Manager>();
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
            // Debug.Log(detectionLayer);
            Destroy(hits[i].collider.gameObject);
            // _shaderManager._opacity = 1;


        }
    }

    private void OnDrawGizmosSelected()
    {
        // Afficher le gizmo de la sphère de rayonnement
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, transform.localScale.x * sphereRadius);
    }
}

