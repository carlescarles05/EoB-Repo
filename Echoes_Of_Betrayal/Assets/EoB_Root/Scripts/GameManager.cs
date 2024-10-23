using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("GameManager is null");
            }
            return _instance;
        }
    }
    #endregion
    [Header("Objetos chech")]
    public bool perezoso = false;
    public bool vaso = false;
    public bool llaves = false;
    public bool movil = false;
    public bool cuchillo = false;
    public bool allCheckItems = false;

    [Header("Fase chech")]
    public bool firstPhase = true;
    public bool secondPhase = false;
    public bool rickDialogueClose = false;

    [Header("Seleccion chech")]
    public bool powa = false;
    public bool rick = false;
    public bool kirei = false;
    public bool fran = false;
    public bool mery = false;
    public bool allChechDialogues;

    [Header("Finale CHECH")]
    public bool risas = false;
    public bool puñaladas = false;
    public bool mirrorFin = false;


    public void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

  
    public void Update()
    {
        if (perezoso == true && llaves == true && vaso == true && movil == true)
        {
            allCheckItems = true;
        }

        if (fran == true && mery == true && rick == true && powa == true && kirei == true)
        {
            allChechDialogues = true;
        }

        Killer();

    }

    public void PEREZOSO()
    {
        perezoso = true;
    }

    public void VASO()
    {
         vaso = true;
    }

    public void LLAVES()
    {
        llaves = true;  
    }

    public void MOVIL()
    {
        movil = true;
    }

    public void CUCHILLO()
    {
        cuchillo = true;
        secondPhase = true;
        firstPhase = false;
    }


    public void Killer()
    {
        if (allChechDialogues == true)
        {
            SceneManager.LoadScene(8);
            allChechDialogues = false;
            powa = false;
        }
    }

}
