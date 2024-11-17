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

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.firstPhase == true)
        {
            textCounter.text = GameManager.Instance.countObject.ToString();
            textIndicator.text = "PISTAS RECOLECTADAS";
        }
        if (GameManager.Instance.secondPhase == false)
        {
            textCounter.text = GameManager.Instance.countObject.ToString();
            textIndicator.text = "SOSPECHOSOS INTERROGADOS";
        }



    }

}
