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

    public GameObject cuchilloGrande;
    public GameObject llavesGrande;
    public GameObject perezosoGrande;
    public GameObject vasoGrande;
    public GameObject movilGrande;


    void Start()
    {

        // Si el GameManager no se asignó en el Inspector, lo busca en la escena
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>(); // Busca el GameManager en toda la escena
        }

        if (gameManager == null)
        {
            Debug.LogError("GameManager no encontrado. Asegúrate de que está en la escena.");
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
    public void PEREZOSOGRANDE()
    {
        perezosoGrande.SetActive(false);
    }

    public void VASO()
    {
        if (gameManager != null)
        {
            gameManager.vaso = true;
            vasoGrande.SetActive(true);
        }
    }
    public void VASOGRANDE()
    {
        vasoGrande.SetActive(false);
    }

    public void LLAVES()
    {
        if (gameManager != null)
        {
            gameManager.llaves = true;
            llavesGrande.SetActive(true);
        }
    }
    public void LLAVESGRANDE()
    {
        llavesGrande.SetActive(false);
    }

    public void MOVIL()
    {
        if (gameManager != null)
        {
            gameManager.movil = true;
            movilGrande.SetActive(true);
        }
    }
    public void MOVILGRANDE()
    {
        movilGrande.SetActive(false);
    }

    public void CUCHILLO()
    {
        if (gameManager != null)
        {
            gameManager.cuchillo = true;
            cuchilloGrande.SetActive(true);
        }
    }
    public void CUCHILLOGRANDE()
    {
        cuchilloGrande.SetActive(false);
    }

}
