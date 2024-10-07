using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwipe : MonoBehaviour
{
    private Vector2 touchStartPosition;
    private Vector2 touchEndPosition;
    private Vector3 cameraStartPosition;

    public float cameraSpeed = 0.5f;  // Ajusta la velocidad del movimiento de la cámara

    void LateUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);  // Detecta el primer toque en la pantalla

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Guarda la posición inicial del toque y de la cámara
                    touchStartPosition = touch.position;
                    cameraStartPosition = Camera.main.transform.position;
                    break;

                case TouchPhase.Moved:
                    // Calcula la diferencia del movimiento del dedo
                    touchEndPosition = touch.position;
                    float swipeDelta = touchEndPosition.x - touchStartPosition.x;

                    // Mueve la cámara horizontalmente según el swipe
                    Camera.main.transform.position = cameraStartPosition - new Vector3(swipeDelta * cameraSpeed * Time.deltaTime, 0, 0);
                    break;
            }
        }
    }
}
