using UnityEngine;

public class PinMovement : MonoBehaviour
{
    private bool isPickedUp = false;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        if (!isPickedUp)
        {
            isPickedUp = true;
        }
        else
        {
            isPickedUp = false;
            // You might want to perform additional logic here,
            // such as checking for valid placement, connecting pins, etc.
        }
    }

    private void Update()
    {
        if (isPickedUp)
        {
            // Calculate the new position based on mouse input or touch input
            Vector3 newPosition = CalculateNewPosition();
            
            // Update the pin's position
            transform.position = newPosition;
        }
    }

    private Vector3 CalculateNewPosition()
    {
        // Calculate the new position based on mouse input or touch input
        // You'll need to use Input.mousePosition or Input.touches to get input data
        // Convert the input position to world space and return it as the new position

        // For simplicity, let's assume we're using mouse input
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    public void ResetPosition()
    {
        // Reset the pin to its initial position
        transform.position = initialPosition;
        isPickedUp = false;
    }
}