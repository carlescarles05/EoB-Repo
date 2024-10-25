using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ChargeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void NO()
    {
        Application.Quit();
    }

    public void ChangeMirror()
    {
        if (GameManager.Instance.secondPhase == true)        
        {
            SceneManager.LoadScene(2);
        }
    }
    public void MIRRORFIN()
    {
        GameManager.Instance.mirrorFin = true;
        SceneManager.LoadScene(7);
    }

    public void RISAS()
    {
        GameManager.Instance.risas = true;
        SceneManager.LoadScene(7);
    }

    public void PUÑALADAS()
    {
        GameManager.Instance.puñaladas = true;
        SceneManager.LoadScene(7);
    }
}
