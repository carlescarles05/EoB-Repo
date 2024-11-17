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
        cameraSwipe.cameraSpeed = cameraSwipe.cameraSpeed * 0;
    }

    public void POWACLOSE()
    {
        Powa.SetActive(false);
        cameraSwipe.cameraSpeed = 1.5f;
        if (GameManager.Instance.powa == false)
        {
            GameManager.Instance.powa = true;
            GameManager.Instance.countObject++;
        
        }
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
        cameraSwipe.cameraSpeed = cameraSwipe.cameraSpeed * 0;
    }
    public void MERYCLOSE()
    {
        Mery.SetActive(false);
        
        cameraSwipe.cameraSpeed = 1.5f;
        if (GameManager.Instance.mery == false)
        {
            GameManager.Instance.countObject++;
            GameManager.Instance.mery = true;
        }
    }

    public void FRAN()
    {
        Fran.SetActive(true);
        cameraSwipe.cameraSpeed = cameraSwipe.cameraSpeed * 0;
    }
    public void FRANCLOSE()
    {
        Fran.SetActive(false);

        cameraSwipe.cameraSpeed = 1.5f;
        if (GameManager.Instance.fran == false)
        {
            GameManager.Instance.countObject++;
            GameManager.Instance.fran = true;
        }
    }

    public void KIREI()
    {
        Kirei.SetActive(true);
        cameraSwipe.cameraSpeed = cameraSwipe.cameraSpeed * 0;
    }
    public void KIREICLOSE()
    {
        Kirei.SetActive(false);
        cameraSwipe.cameraSpeed = 1.5f;
        
        if (GameManager.Instance.kirei == false)
        {
            GameManager.Instance.countObject++;
            GameManager.Instance.kirei = true;
        }
        
    }

}
