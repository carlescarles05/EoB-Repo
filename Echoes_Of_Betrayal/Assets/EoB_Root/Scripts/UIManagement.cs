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
        perezosoGrande.SetActive(true);
        
    }
    public void PEREZOSOGRANDE()
    {
        
        perezosoGrande.SetActive(false);
        if (GameManager.Instance.firstPhase == true && GameManager.Instance.perezoso == false)
        {
            GameManager.Instance.perezoso = true;
            GameManager.Instance.countObject++;
        }
    }

    public void VASO()
    {
        vasoGrande.SetActive(true);

    }
    public void VASOGRANDE()
    {
        vasoGrande.SetActive(false);
        if (GameManager.Instance.firstPhase == true && GameManager.Instance.vaso == false)
        {
            GameManager.Instance.countObject++;
            GameManager.Instance.vaso = true;
        }
    }

    public void LLAVES()
    {
        llavesGrande.SetActive(true);

    }
    public void LLAVESGRANDE()
    {
        if (GameManager.Instance.firstPhase == true && GameManager.Instance.llaves == false)
        {
            GameManager.Instance.countObject++;
            GameManager.Instance.llaves = true;

        }
        llavesGrande.SetActive(false);
        
    }

    public void MOVIL()
    {
        movilGrande.SetActive(true);

    }
    public void MOVILGRANDE()
    {
        movilGrande.SetActive(false);
        if (GameManager.Instance.firstPhase == true && GameManager.Instance.movil == false)
        {
            GameManager.Instance.countObject++;
            GameManager.Instance.movil = true;
        }
    }

    public void CUCHILLO()
    {
        cuchilloGrande.SetActive(true);

    }
    public void CUCHILLOGRANDE(bool yaHanHablado = false)
    {
        cuchilloGrande.SetActive(false);
        GameManager.Instance.secondPhase = true;
        GameManager.Instance.countObject = 1;
        if (GameManager.Instance.cuchillo == false)
        {
            GameManager.Instance.cuchillo = true;
        }
    }

    public void TAQUILLA()
    {
        
    }

    
}
