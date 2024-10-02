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

    public void POWA()
    {

    }

}
