using UnityEngine;

public class TraceLineToText : MonoBehaviour
{
    public Collider targetCollider;
    public LineRenderer lineRenderer;
    void Update()
    {
        Vector3 targetPosition = targetCollider.ClosestPoint(transform.position);
        lineRenderer.SetPosition(0, Vector3.zero);
        lineRenderer.SetPosition(1, (targetPosition - transform.position));
    }
}
