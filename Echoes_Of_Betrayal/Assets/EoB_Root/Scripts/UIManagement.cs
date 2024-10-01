using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.AudioSettings;

public class UIManagement : MonoBehaviour
{

    /*public GameManager gameManager;


    // Update is called once per frame
    void Update()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void PEREZOSO()
    {
        gameManager.perezoso = true;
    }

    public void VASO()
    {
        gameManager.vaso = true;
    }

    public void LLAVES()
    {
        gameManager.llaves = true;
    }

    public void MOVIL()
    {
        gameManager.movil = true;
    }*/

    // Asignar el GameManager desde el Inspector
    private GameManager gameManager;

    private GameObject cuchilloGrande;
    private GameObject llavesGrande;
    private GameObject perezosoGrande;
    private GameObject vasoGrande;
    private GameObject movilGrande;


    void Start()
    {

        // Si el GameManager no se asign� en el Inspector, lo busca en la escena
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>(); // Busca el GameManager en toda la escena
        }

        if (gameManager == null)
        {
            Debug.LogError("GameManager no encontrado. Aseg�rate de que est� en la escena.");
        }
    }


    public void PEREZOSO()
    {
        if (gameManager != null)
        {
            gameManager.perezoso = true;
            perezosoGrande.SetActive(true);
        }
    }

    public void VASO()
    {
        if (gameManager != null)
        {
            gameManager.vaso = true;
            vasoGrande.SetActive(true);
        }
    }

    public void LLAVES()
    {
        if (gameManager != null)
        {
            gameManager.llaves = true;
            llavesGrande.SetActive(true);
        }
    }

    public void MOVIL()
    {
        if (gameManager != null)
        {
            gameManager.movil = true;
            movilGrande.SetActive(true);
        }
    }

    public void CUCHILLO()
    {
        if (gameManager != null)
        {
            gameManager.cuchillo = true;
            cuchilloGrande.SetActive(true);
        }
    }

}
