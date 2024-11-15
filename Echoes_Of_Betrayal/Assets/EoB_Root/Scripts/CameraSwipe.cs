using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwipe : MonoBehaviour
{
    private Vector2 touchStartPosition;
    private Vector3 cameraStartPosition;

    public float cameraSpeed = 0.5f;  // Ajusta la velocidad del movimiento de la c�mara

    // L�mites de movimiento de la c�mara
    public float minCameraX = -5f;  // L�mite izquierdo
    public float maxCameraX = 5f;   // L�mite derecho

    void LateUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Guardamos la posici�n inicial del toque y la posici�n de la c�mara
                    touchStartPosition = touch.position;
                    cameraStartPosition = Camera.main.transform.position;
                    break;

                case TouchPhase.Moved:
                    // Calculamos la diferencia en el eje X
                    float swipeDeltaX = (touch.position.x - touchStartPosition.x) * cameraSpeed * Time.deltaTime;

                    // Calculamos la nueva posici�n potencial de la c�mara
                    float newCameraPosX = cameraStartPosition.x - swipeDeltaX;

                    // Aplicamos los l�mites usando Mathf.Clamp para que la c�mara no sobrepase los valores m�ximos y m�nimos
                    newCameraPosX = Mathf.Clamp(newCameraPosX, minCameraX, maxCameraX);

                    // Actualizamos la posici�n de la c�mara
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

    public float cameraSpeed = 0.5f;  // Ajusta la velocidad del movimiento de la c�mara

    // L�mites de movimiento de la c�mara
    public float minCameraX = -5f;  // L�mite izquierdo
    public float maxCameraX = 5f;   // L�mite derecho

    void LateUpdate()
    {
        // Comprobar si el bot�n izquierdo del rat�n est� siendo presionado
        if (Input.GetMouseButtonDown(0))
        {
            // Guardamos la posici�n inicial del rat�n y la posici�n de la c�mara
            startMousePosition = Input.mousePosition;
            cameraStartPosition = Camera.main.transform.position;
        }

        // Comprobar si el bot�n izquierdo del rat�n se est� arrastrando
        if (Input.GetMouseButton(0))
        {
            // Calculamos la diferencia en el eje X
            float swipeDeltaX = (Input.mousePosition.x - startMousePosition.x) * cameraSpeed * Time.deltaTime;

            // Calculamos la nueva posici�n potencial de la c�mara
            float newCameraPosX = cameraStartPosition.x - swipeDeltaX;

            // Aplicamos los l�mites usando Mathf.Clamp para que la c�mara no sobrepase los valores m�ximos y m�nimos
            newCameraPosX = Mathf.Clamp(newCameraPosX, minCameraX, maxCameraX);

            // Actualizamos la posici�n de la c�mara
            Camera.main.transform.position = new Vector3(newCameraPosX, Camera.main.transform.position.y, Camera.main.transform.position.z);
        }
    }
}*/
