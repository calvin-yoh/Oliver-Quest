using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaBagScript : MonoBehaviour
{
    [SerializeField] private Transform finalPosition;
    [SerializeField] private Vector2 initialPosition;
    [SerializeField] private float deltaX, deltaY;

    public static bool locked;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        checkForMobileInput();
        checkForDesktopInput();
    }

    public void checkForMobileInput()
    {
        if ((Input.touchCount > 0) && !locked)
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
                    {
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    }
                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - finalPosition.position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - finalPosition.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(finalPosition.position.x, finalPosition.position.y);
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

    public void checkForDesktopInput()
    {
        if (Input.GetMouseButton(0) && !locked)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                transform.position = new Vector2(pos.x - deltaX, pos.y - deltaY);
            }

            if (Mathf.Abs(transform.position.x - finalPosition.position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - finalPosition.position.y) <= 0.5f)
            {
                transform.position = new Vector2(finalPosition.position.x, finalPosition.position.y);
                locked = true;
            }
        }
        if (!Input.GetMouseButton(0) && !locked)
        {
            transform.position = initialPosition;
        }
    }

    public bool GetLocked()
    {
        return locked;
    }

}
