using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public bool perezoso = false;
    public bool vaso = false;
    public bool llaves = false;
    public bool movil = false;
    public bool cuchillo = false;


   
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

    private void Awake()
    {
        _instance = this;
    }

    public void ChargeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
