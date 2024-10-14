using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagement : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject Powa;
    public GameObject Rick;
    public GameObject Mery;
    public GameObject Fran;
    public GameObject Kirei;

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

    private void Update()
    {
        if (gameManager.secondPhase == true)
        {

        }
    }

    public void POWA()
    {
        if (gameManager != null)
        {
            Powa.SetActive(true);
        }
    }

    public void POWACLOSE()
    {
        Powa.SetActive(false);
    }

    public void RICK()
    {
        if (gameManager != null) 
        {
            Rick.SetActive(true);
        }
    }
    public void RICKCLOSE()
    {
        Rick.SetActive(false);
        gameManager.rickDialogueClose = true;
    }

    public void MERY()
    {
        if (gameManager != null)
        {
            Mery.SetActive(true);
        }
    }
    public void MERYCLOSE()
    {
        Mery.SetActive(false);
    }

    public void FRAN()
    {
        if (gameManager != null)
        {
            Fran.SetActive(true);
        }
    }
    public void FRANCLOSE()
    {
        Fran.SetActive(false);
    }

    public void KIREI()
    {
        if (gameManager != null)
        {
            Kirei.SetActive(true);
        }
    }
    public void KIREICLOSE()
    {
        Kirei.SetActive(false);
    }

    
}
