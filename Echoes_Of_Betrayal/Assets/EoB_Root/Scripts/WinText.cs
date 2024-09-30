using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinText : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;

    private Mirror[] mirrors; // Para almacenar todas las piezas del puzzle

    private void Start()
    {
        winText.SetActive(false);
        // Encuentra todas las piezas (Mirror) en la escena
        mirrors = FindObjectsOfType<Mirror>();
    }

    private void Update()
    {
        // Verifica si todas las piezas est�n bloqueadas
        bool allLocked = true;
        foreach (Mirror mirror in mirrors)
        {
            if (!mirror.locked)
            {
                allLocked = false;
                break; // Si alguna no est� bloqueada, ya no es necesario seguir comprobando
            }
        }

        // Si todas las piezas est�n bloqueadas, activa el texto de victoria
        if (allLocked)
        {
            winText.SetActive(true);
        }
    }
}
