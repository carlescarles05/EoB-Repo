using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public bool one = false;
    public bool two = false;

    public void ONE()
    {
        one = true;
    }

    public void TWO()
    {
        two = true;
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

    public void ChargeScene()
    {
        SceneManager.LoadScene(0);
    }

}
