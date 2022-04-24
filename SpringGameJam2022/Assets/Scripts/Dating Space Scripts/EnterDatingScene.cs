using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDatingScene : MonoBehaviour
{

    [SerializeField]
    private Canvas screen;

    private ConfirmButtons confirmationScreen;

    private ElementInfo elementInfo;

    private void Start()
    {
        confirmationScreen = screen.GetComponent<ConfirmButtons>();
        elementInfo = gameObject.GetComponent<ElementInfo>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Element"))
        {

            ElementInfo newElementInfo = collision.gameObject.GetComponent<ElementInfo>();

            Debug.Log(newElementInfo.GetElementName());

            if (newElementInfo.BondReady() || elementInfo.BondReady())

            {
                string elemOne = elementInfo.GetElementName();
                string elemTwo = newElementInfo.GetElementName();

                if (elementInfo.CheckIfPossibleElement(elemTwo))
                {

                    if (elemTwo == "Hydrogen")
                    {
                        confirmationScreen.PopUp(
                            elemOne,
                            elemTwo,
                            elementInfo.GetElementScene(0));
                    }
                    else if (elemTwo == "Chlorine")
                    {
                        confirmationScreen.PopUp(
                            elemOne,
                            elemTwo,
                            elementInfo.GetElementScene(1));
                    }
                    else if (elemTwo == "Carbon")
                    {
                        confirmationScreen.PopUp(
                            elemOne,
                            elemTwo,
                            elementInfo.GetElementScene(2));
                    }
                    else if (elemTwo == "Sodium")
                    {
                        confirmationScreen.PopUp(
                            elemOne,
                            elemTwo,
                            elementInfo.GetElementScene(3));
                    }

                }
            }
        }
    }
}
