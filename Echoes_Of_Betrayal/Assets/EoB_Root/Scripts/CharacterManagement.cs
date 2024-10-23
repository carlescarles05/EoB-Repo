using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagement : MonoBehaviour
{

    public GameObject Powa;
    public GameObject Rick;
    public GameObject Mery;
    public GameObject Fran;
    public GameObject Kirei;

    public GameObject contenedorCharacter;


    private void Update()
    {
        if (GameManager.Instance.secondPhase == true)
        {
            contenedorCharacter.SetActive(true);
        }
    }

    public void POWA()
    {
            Powa.SetActive(true);
    }

    public void POWACLOSE()
    {
        Powa.SetActive(false);
        GameManager.Instance.powa = true;
    }

    public void RICK()
    {
            Rick.SetActive(true);
        
    }
    public void RICKCLOSE()
    {
        Rick.SetActive(false);
        GameManager.Instance.rickDialogueClose = true;
        GameManager.Instance.rick = true;
    }

    public void MERY()
    {
        Mery.SetActive(true);
        
    }
    public void MERYCLOSE()
    {
        Mery.SetActive(false);
        GameManager.Instance.mery = true;
    }

    public void FRAN()
    {
        Fran.SetActive(true);
        
    }
    public void FRANCLOSE()
    {
        Fran.SetActive(false);
        GameManager.Instance.fran = true;
    }

    public void KIREI()
    {
        Kirei.SetActive(true);
        
    }
    public void KIREICLOSE()
    {
        Kirei.SetActive(false);
        GameManager.Instance.kirei = true;
    }

}
