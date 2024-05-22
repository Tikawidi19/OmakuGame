using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Karakter atau objek yang ingin diikuti kamera
    public float smoothSpeed = 0.125f; // Kecepatan pergerakan kamera
    public Vector3 offset; // Jarak relatif antara kamera dan target

    void FixedUpdate()
    {

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            //transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z); // Menahan pergerakan kamera di sumbu z

            transform.position = smoothedPosition;
            transform.LookAt(target);
            // Optional: Jika Anda ingin kamera hanya bergerak ke kanan atau ke kiri
            //transform.position = new Vector3(smoothedPosition.x, transform.position.y, transform.position.z);
        
    }
}
