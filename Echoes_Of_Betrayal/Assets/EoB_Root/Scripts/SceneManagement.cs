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
            SceneManager.LoadScene(4);
        }
    }
}
