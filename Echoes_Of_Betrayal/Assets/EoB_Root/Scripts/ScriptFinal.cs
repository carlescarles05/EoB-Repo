using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFinañ : MonoBehaviour
{
    [SerializeField] GameObject[] Finales;

    // Update is called once per frame
    void Update()
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
