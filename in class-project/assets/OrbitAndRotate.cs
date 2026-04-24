using UnityEngine;

public class OrbitAndRotate : MonoBehaviour
{
    public Transform orbitCenter;
    public float orbitSpeed = 20f;
    public float rotationSpeed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        if (orbitCenter != null)
        {
            transform.RotateAround(
                orbitCenter.position,
                Vector3.up,
                orbitSpeed * Time.deltaTime
            );
        }
    }
}