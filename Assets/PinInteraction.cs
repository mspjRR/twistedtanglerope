using UnityEngine;

public class PinInteraction : MonoBehaviour
{
    public GameObject ropePrefab; // Reference to your rope prefab
    private GameObject currentRope; // Reference to the instantiated rope object
    private bool isConnected = false;
    private Transform connectedPin;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isConnected)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                
                if (Physics.Raycast(ray, out hit))
                {
                    PinInteraction otherPinInteraction = hit.transform.GetComponent<PinInteraction>();
                    if (otherPinInteraction != null && otherPinInteraction != this)
                    {
                        ConnectPins(otherPinInteraction);
                    }
                }
            }
            else
            {
                DisconnectRope();
            }
        }
    }

    void ConnectPins(PinInteraction otherPinInteraction)
    {
        isConnected = true;
        connectedPin = otherPinInteraction.transform;

        // Instantiate the rope prefab and position it
        currentRope = Instantiate(ropePrefab, Vector3.zero, Quaternion.identity);
        // Position the rope object between the pins
        currentRope.transform.position = (transform.position + connectedPin.position) / 2;
        // Set the rope's end points to the pins' positions
        currentRope.GetComponent<RopeController>().ConnectRope(transform, connectedPin);
    }

    void DisconnectRope()
    {
        isConnected = false;
        connectedPin = null;
        if (currentRope != null)
        {
            Destroy(currentRope);
        }
    }
}
