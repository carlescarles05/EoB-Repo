using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFinañ : MonoBehaviour
{
    [SerializeField] GameObject[] Finales;
    


    public AudioSource audioSource;

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }



        if (GameManager.Instance.mirrorFin == true)
        {
            Finales[1].SetActive(false);
            Finales[2].SetActive(false);
            audioSource.Pause();
        }
        if (GameManager.Instance.puñaladas == true)
        {
            Finales[0].SetActive(false);
            Finales[2].SetActive(false);
            audioSource.Play();
        }
        if (GameManager.Instance.risas == true)
        {
            Finales[0].SetActive(false);
            Finales[1].SetActive(false);
            audioSource.Pause();
        }
    }
}
