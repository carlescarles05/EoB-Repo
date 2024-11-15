using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwipe : MonoBehaviour
{
    private Vector2 touchStartPosition;
    private Vector3 cameraStartPosition;

    public float cameraSpeed = 0.5f;  // Ajusta la velocidad del movimiento de la cámara

    // Límites de movimiento de la cámara
    public float minCameraX = -5f;  // Límite izquierdo
    public float maxCameraX = 5f;   // Límite derecho

    void LateUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Guardamos la posición inicial del toque y la posición de la cámara
                    touchStartPosition = touch.position;
                    cameraStartPosition = Camera.main.transform.position;
                    break;

                case TouchPhase.Moved:
                    // Calculamos la diferencia en el eje X
                    float swipeDeltaX = (touch.position.x - touchStartPosition.x) * cameraSpeed * Time.deltaTime;

                    // Calculamos la nueva posición potencial de la cámara
                    float newCameraPosX = cameraStartPosition.x - swipeDeltaX;

                    // Aplicamos los límites usando Mathf.Clamp para que la cámara no sobrepase los valores máximos y mínimos
                    newCameraPosX = Mathf.Clamp(newCameraPosX, minCameraX, maxCameraX);

                    // Actualizamos la posición de la cámara
                    Camera.main.transform.position = new Vector3(newCameraPosX, Camera.main.transform.position.y, Camera.main.transform.position.z);
                    break;
            }
        }
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwipe : MonoBehaviour
{
    private Vector2 startMousePosition;
    private Vector3 cameraStartPosition;

    public float cameraSpeed = 0.5f;  // Ajusta la velocidad del movimiento de la cámara

    // Límites de movimiento de la cámara
    public float minCameraX = -5f;  // Límite izquierdo
    public float maxCameraX = 5f;   // Límite derecho

    void LateUpdate()
    {
        // Comprobar si el botón izquierdo del ratón está siendo presionado
        if (Input.GetMouseButtonDown(0))
        {
            // Guardamos la posición inicial del ratón y la posición de la cámara
            startMousePosition = Input.mousePosition;
            cameraStartPosition = Camera.main.transform.position;
        }

        // Comprobar si el botón izquierdo del ratón se está arrastrando
        if (Input.GetMouseButton(0))
        {
            // Calculamos la diferencia en el eje X
            float swipeDeltaX = (Input.mousePosition.x - startMousePosition.x) * cameraSpeed * Time.deltaTime;

            // Calculamos la nueva posición potencial de la cámara
            float newCameraPosX = cameraStartPosition.x - swipeDeltaX;

            // Aplicamos los límites usando Mathf.Clamp para que la cámara no sobrepase los valores máximos y mínimos
            newCameraPosX = Mathf.Clamp(newCameraPosX, minCameraX, maxCameraX);

            // Actualizamos la posición de la cámara
            Camera.main.transform.position = new Vector3(newCameraPosX, Camera.main.transform.position.y, Camera.main.transform.position.z);
        }
    }
}*/
