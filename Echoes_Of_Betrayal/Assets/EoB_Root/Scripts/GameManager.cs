using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;


    public bool perezoso = false;
    public bool vaso = false;
    public bool llaves = false;
    public bool movil = false;
    public bool cuchillo = false;

    public bool allCheckItems = false;
    public bool firstPhase = true;
    public bool secondPhase = false;
    public bool rickDialogueClose = false;

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

    public void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ChargeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Update()
    {
        if (perezoso == true && llaves == true && vaso == true && movil == true)
        {
            allCheckItems = true;
        }
    }

    

}
