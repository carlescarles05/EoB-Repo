using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer1 : MonoBehaviour
{

    public TextMeshProUGUI textCounter;
    public TextMeshProUGUI textIndicator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.Instance.firstPhase == true)
        {
            textCounter.text = GameManager.Instance.countObject.ToString();
            textIndicator.text = "PISTAS RECOLECTADAS";
        }
        if (GameManager.Instance.secondPhase == true)
        {
            textCounter.text = GameManager.Instance.countObject.ToString();
            textIndicator.text = "SOSPECHOSOS INTERROGADOS";
        }

    }

}
