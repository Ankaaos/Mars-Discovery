using UnityEngine;

public class WheelSuspension : MonoBehaviour
{
    public float suspensionDistance = 0.5f;
    public float suspensionDamping = 0.5f;
    public float suspensionSpring = 1000f;

    private RaycastHit hit;
    private Vector3 wheelStartPosition;
    private Rigidbody rb;

    private void Start()
    {
        wheelStartPosition = transform.localPosition;
        rb = GetComponentInParent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, -transform.up, out hit, suspensionDistance))
        {
            float distance = suspensionDistance - hit.distance;
            Vector3 force = rb.mass * distance * suspensionSpring * -transform.up - suspensionDamping * rb.GetPointVelocity(hit.point);
            rb.AddForceAtPosition(force, hit.point);
        }
    }

    private void Update()
    {
        Vector3 targetPosition = wheelStartPosition;

        if (Physics.Raycast(transform.position, -transform.up, out hit, suspensionDistance))
        {
            targetPosition = hit.point + hit.normal * GetComponent<Renderer>().bounds.extents.y;
        }

        transform.localPosition = targetPosition;
    }
}