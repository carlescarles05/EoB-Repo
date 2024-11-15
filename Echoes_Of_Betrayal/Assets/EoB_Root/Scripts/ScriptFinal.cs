using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ScriptFinañ : MonoBehaviour
{
    [SerializeField] GameObject[] Finales;
   

    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {



        if (GameManager.Instance.mirrorFin == true)
        {
            Finales[1].SetActive(false);
            Finales[2].SetActive(false);
        }
        if (GameManager.Instance.puñaladas == true)
        {
            Finales[0].SetActive(false);
            Finales[2].SetActive(false);
        }
        if (GameManager.Instance.risas == true)
        {
            Finales[0].SetActive(false);
            Finales[1].SetActive(false);
        }
    }
}
