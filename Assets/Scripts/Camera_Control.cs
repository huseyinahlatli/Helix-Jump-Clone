using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{

    public Transform ball;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
        offset = transform.position - ball.position;
    }

    void Update()
    {
        // Lerp = 2 nokta arasını istediğimiz gibi doldurulabilir.
        Vector3 newPosition = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed);
        transform.position = newPosition;
    }
}
