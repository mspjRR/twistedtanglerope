using UnityEngine;

public class RopeController : MonoBehaviour
{
    public float ropeLength = 1.0f; // Length of the rope

    private LineRenderer lineRenderer;
    private Transform startPoint;
    private Transform endPoint;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        startPoint = transform.Find("StartPoint"); // Adjust this to your rope's start point transform
        endPoint = transform.Find("EndPoint");     // Adjust this to your rope's end point transform
        lineRenderer.positionCount = 2;
        lineRenderer.enabled = false;
    }

    void Update()
    {
        // Update rope appearance and position based on the start and end points
        UpdateRopeAppearance();
    }

    public void ConnectRope(Transform startPin, Transform endPin)
    {
        startPoint = startPin;
        endPoint = endPin;
        lineRenderer.enabled = true;
        UpdateRopeAppearance();
    }

    public void DisconnectRope()
    {
        startPoint = null;
        endPoint = null;
        lineRenderer.enabled = false;
    }

    void UpdateRopeAppearance()
    {
        if (startPoint != null && endPoint != null)
        {
            lineRenderer.SetPosition(0, startPoint.position);
            lineRenderer.SetPosition(1, endPoint.position);

            // Adjust the rope's visual properties (material, texture, etc.) as needed
            // You might also consider adding animation or physics-based behavior to the rope.
        }
    }
}
