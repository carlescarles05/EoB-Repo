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
    [SerializeField] GameObject cineStart; // Cinem�tica de inicio
    [SerializeField] GameObject cineFinish; // Cinem�tica de finalizaci�n

    [SerializeField] VideoPlayer videoPlayer; // El VideoPlayer para reproducir el video

    private Mirror[] mirrors; // Para almacenar todas las piezas del puzzle
    private bool puzzleCompleted = false; // Para evitar que se repita la cinem�tica

    private void Start()
    {
        // Encuentra todas las piezas (Mirror) en la escena
        mirrors = FindObjectsOfType<Mirror>();

        // Aseg�rate de que el VideoPlayer est� desactivado al principio (si es necesario)
        if (videoPlayer != null)
        {
            videoPlayer.gameObject.SetActive(false); // O simplemente no reproducir el video a�n
        }
    }

    void Update()
    {
        // Solo revisa si el puzzle a�n no se ha completado
        if (!puzzleCompleted)
        {
            // Verifica si todas las piezas est�n bloqueadas
            bool allLocked = true;
            foreach (Mirror mirror in mirrors)
            {
                if (!mirror.locked)
                {
                    allLocked = false;
                    break; // Si alguna no est� bloqueada, no hace falta seguir revisando
                }
            }

            // Si todas las piezas est�n bloqueadas, inicia la reproducci�n del video
            if (allLocked)
            {
                puzzleCompleted = true;
                PlayVideo(); // Reproduce el video
            }
        }
    }

    public void StartSkip()
    {
        cineStart.SetActive(false); // Desactiva la cinem�tica de inicio
    }

    public void PlayVideo()
    {
        // Activa el objeto que contiene el VideoPlayer
        if (videoPlayer != null)
        {
            videoPlayer.gameObject.SetActive(true);
            videoPlayer.Play(); // Reproduce el video
            Debug.Log("�Puzzle completado! Reproduciendo video.");
        }
        else
        {
            Debug.LogError("No se ha asignado el VideoPlayer.");
        }
    }
}

