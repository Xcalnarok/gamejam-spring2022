using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    [SerializeField]
    private GameObject mainObject;


    private Vector2 difference = Vector2.zero;

    private Shakey objectMovement;
    private ElementInfo elementInfo;

    private void Start()
    {
        objectMovement = gameObject.GetComponent<Shakey>();
        elementInfo = gameObject.GetComponent<ElementInfo>();
    }

    private void Update()
    {
        //Debug.Log((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //mainObject.transform.position = transform.position;
    }

    private void OnMouseDown()
    {
        objectMovement.MovementOff();
        difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.parent.position;
        elementInfo.SetBondOn();
        
    }

    private void OnMouseDrag()
    {
        transform.parent.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    private void OnMouseUp()
    {
        objectMovement.MovementOn();
        mainObject.transform.position = transform.position;

        elementInfo.SetBondOff();
    }
}
