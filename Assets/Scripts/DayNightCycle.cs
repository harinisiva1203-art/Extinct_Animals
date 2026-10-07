using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time in seconds for a full day-night cycle")]
    public float dayDuration = 60f; 

    void Update()
    {
        // Calculate degrees per second based on the desired day duration (360 degrees total)
        float rotationSpeed = 360f / dayDuration;

        // Rotate the light around the X-axis over time
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
