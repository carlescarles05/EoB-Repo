using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cinematics : MonoBehaviour
{

    [Header("Cinematicas")]
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
    }

}

