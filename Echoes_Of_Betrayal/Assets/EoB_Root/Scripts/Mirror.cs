using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mirror : MonoBehaviour
{
    [SerializeField]
    private Transform mirrorPlace;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public bool locked;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - mirrorPlace.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - mirrorPlace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(mirrorPlace.position.x, mirrorPlace.position.y);
                        locked = true;
                    }
                    else
                    {
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                    break;
            }
        }
    }
    
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    [SerializeField]
    private Transform mirrorPlace;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public bool locked;

    private Collider2D objectCollider;

    private void Start()
    {
        initialPosition = transform.position;
        objectCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (!locked)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                // Detecta si el objeto fue clicado
                if (objectCollider == Physics2D.OverlapPoint(mousePos))
                {
                    deltaX = mousePos.x - transform.position.x;
                    deltaY = mousePos.y - transform.position.y;
                }
            }

            if (Input.GetMouseButton(0))
            {
                // Mueve el objeto con el ratón si se mantiene presionado el botón izquierdo
                if (objectCollider == Physics2D.OverlapPoint(mousePos))
                {
                    transform.position = new Vector2(mousePos.x - deltaX, mousePos.y - deltaY);
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                // Suelta el objeto y verifica si debe bloquearse en el lugar objetivo
                if (Mathf.Abs(transform.position.x - mirrorPlace.position.x) <= 0.5f &&
                    Mathf.Abs(transform.position.y - mirrorPlace.position.y) <= 0.5f)
                {
                    transform.position = new Vector2(mirrorPlace.position.x, mirrorPlace.position.y);
                    locked = true;
                }
                else
                {
                    transform.position = initialPosition;
                }
            }
        }
    }
}*/


