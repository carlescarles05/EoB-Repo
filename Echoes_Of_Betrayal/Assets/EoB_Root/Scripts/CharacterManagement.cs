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

    void Start()
    {

        
    }

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
    }

    public void RICK()
    {
            Rick.SetActive(true);
        
    }
    public void RICKCLOSE()
    {
        Rick.SetActive(false);
        GameManager.Instance.rickDialogueClose = true;
    }

    public void MERY()
    {
            Mery.SetActive(true);
        
    }
    public void MERYCLOSE()
    {
        Mery.SetActive(false);
    }

    public void FRAN()
    {
            Fran.SetActive(true);
        
    }
    public void FRANCLOSE()
    {
        Fran.SetActive(false);
    }

    public void KIREI()
    {
            Kirei.SetActive(true);
        
    }
    public void KIREICLOSE()
    {
        Kirei.SetActive(false);
    }

    
}
