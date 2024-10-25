using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagement : MonoBehaviour
{

    public CameraSwipe cameraSwipe;

    public GameObject Powa;
    public GameObject Rick;
    public GameObject Mery;
    public GameObject Fran;
    public GameObject Kirei;

    public GameObject contenedorCharacter;


    private void Start()
    {
        cameraSwipe = GetComponent<CameraSwipe>();
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
        cameraSwipe.cameraSpeed = 0f;
    }

    public void POWACLOSE()
    {
        Powa.SetActive(false);
        GameManager.Instance.powa = true;
        cameraSwipe.cameraSpeed = 0.5f;
    }

    public void RICK()
    {
        Rick.SetActive(true);
        cameraSwipe.cameraSpeed = 0f;

    }
    public void RICKCLOSE()
    {
        Rick.SetActive(false);
        GameManager.Instance.rickDialogueClose = true;
        GameManager.Instance.rick = true;
        cameraSwipe.cameraSpeed = 0.5f;
    }

    public void MERY()
    {
        Mery.SetActive(true);
        cameraSwipe.cameraSpeed = 0f;
    }
    public void MERYCLOSE()
    {
        Mery.SetActive(false);
        GameManager.Instance.mery = true;
        cameraSwipe.cameraSpeed = 0.5f;
    }

    public void FRAN()
    {
        Fran.SetActive(true);
        cameraSwipe.cameraSpeed = 0f;
    }
    public void FRANCLOSE()
    {
        Fran.SetActive(false);
        GameManager.Instance.fran = true;
        cameraSwipe.cameraSpeed = 0.5f;
    }

    public void KIREI()
    {
        Kirei.SetActive(true);
        cameraSwipe.cameraSpeed = 0f;
    }
    public void KIREICLOSE()
    {
        Kirei.SetActive(false);
        GameManager.Instance.kirei = true;
        cameraSwipe.cameraSpeed = 0.5f;
    }

}
