using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Cinematics : MonoBehaviour
{

    /*[Header("Cinematicas")]
    [SerializeField] GameObject cineStart;
    [SerializeField] GameObject cineFinish;

    private Mirror[] mirrors; // Para almacenar todas las piezas del puzzle

    private void Start()
    {
        gameObject.SetActive(false);
        // Encuentra todas las piezas (Mirror) en la escena
        mirrors = FindObjectsOfType<Mirror>();
    }


    void Update()
    {
           {
            // Verifica si todas las piezas están bloqueadas
            bool allLocked = true;
            foreach (Mirror mirror in mirrors)
            {
                if (!mirror.locked)
                {
                    allLocked = false;
                    break; // Si alguna no está bloqueada, ya no es necesario seguir comprobando
                }
            }
            if (allLocked)
            {
                FinishSkip();
            }
        }
    }

    public void StartSkip()
    {
        cineStart.SetActive(false);
    }
    public void FinishSkip()
    {

        cineFinish.SetActive(true);
    }*/
    [Header("Cinematicas")]
    [SerializeField] GameObject cineStart; // Cinemática de inicio
    [SerializeField] GameObject cineFinish; // Cinemática de finalización

    [SerializeField] VideoPlayer videoPlayer; // El VideoPlayer para reproducir el video

    private Mirror[] mirrors; // Para almacenar todas las piezas del puzzle
    private bool puzzleCompleted = false; // Para evitar que se repita la cinemática

    private void Start()
    {
        // Encuentra todas las piezas (Mirror) en la escena
        mirrors = FindObjectsOfType<Mirror>();

        // Asegúrate de que el VideoPlayer esté desactivado al principio (si es necesario)
        if (videoPlayer != null)
        {
            videoPlayer.gameObject.SetActive(false); // O simplemente no reproducir el video aún
        }
    }

    void Update()
    {
        // Solo revisa si el puzzle aún no se ha completado
        if (!puzzleCompleted)
        {
            // Verifica si todas las piezas están bloqueadas
            bool allLocked = true;
            foreach (Mirror mirror in mirrors)
            {
                if (!mirror.locked)
                {
                    allLocked = false;
                    break; // Si alguna no está bloqueada, no hace falta seguir revisando
                }
            }

            // Si todas las piezas están bloqueadas, inicia la reproducción del video
            if (allLocked)
            {
                puzzleCompleted = true;
                PlayVideo(); // Reproduce el video
            }
        }
    }

    public void StartSkip()
    {
        cineStart.SetActive(false); // Desactiva la cinemática de inicio
    }

    public void PlayVideo()
    {
        // Activa el objeto que contiene el VideoPlayer
        if (videoPlayer != null)
        {
            videoPlayer.gameObject.SetActive(true);
            videoPlayer.Play(); // Reproduce el video
            Debug.Log("¡Puzzle completado! Reproduciendo video.");
        }
        else
        {
            Debug.LogError("No se ha asignado el VideoPlayer.");
        }
    }
}

