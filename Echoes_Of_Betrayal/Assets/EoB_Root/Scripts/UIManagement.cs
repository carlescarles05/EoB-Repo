using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.AudioSettings;

public class UIManagement : MonoBehaviour
{
    [Header("ObjetosGrandes")]
    public GameObject cuchilloGrande;
    public GameObject llavesGrande;
    public GameObject perezosoGrande;
    public GameObject vasoGrande;
    public GameObject movilGrande;

    [Header("Environment")]
    public GameObject taquilla;

    //[Header("SeleccionDeAsesino")]
    //[SerializeField] GameObject canvasPersonajeKiller;
    


    void Update()
    {
        if (GameManager.Instance.allChechDialogues == true)
        {
            //canvasPersonajeKiller.SetActive(true);
        }
    }

    public void PEREZOSO()
    {
        GameManager.Instance.perezoso = true;
        perezosoGrande.SetActive(true);
        
    }
    public void PEREZOSOGRANDE()
    {
        perezosoGrande.SetActive(false);
        if (GameManager.Instance.firstPhase == true)
        {
            GameManager.Instance.countObject++;
        }
    }

    public void VASO()
    {
        GameManager.Instance.vaso = true;
        vasoGrande.SetActive(true);

    }
    public void VASOGRANDE()
    {
        vasoGrande.SetActive(false);
        if (GameManager.Instance.firstPhase == true)
        {
            GameManager.Instance.countObject++;
        }
    }

    public void LLAVES()
    {
        GameManager.Instance.llaves = true;
        llavesGrande.SetActive(true);

    }
    public void LLAVESGRANDE()
    {
        if (GameManager.Instance.firstPhase == true)
        {
            GameManager.Instance.countObject++;
        }
        llavesGrande.SetActive(false);
        
    }

    public void MOVIL()
    {
        GameManager.Instance.movil = true;
        movilGrande.SetActive(true);

    }
    public void MOVILGRANDE()
    {
        movilGrande.SetActive(false);
        if (GameManager.Instance.firstPhase == true)
        {
            GameManager.Instance.countObject++;
        }
    }

    public void CUCHILLO()
    {
        GameManager.Instance.cuchillo = true;
        cuchilloGrande.SetActive(true);

    }
    public void CUCHILLOGRANDE()
    {
        cuchilloGrande.SetActive(false);
        GameManager.Instance.secondPhase = true;
        GameManager.Instance.countObject = 1;
    }

    public void TAQUILLA()
    {
        
    }

    
}
