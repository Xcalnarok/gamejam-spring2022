using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDatingScene : MonoBehaviour
{

    public UnityEditor.SceneAsset sceneChange;

    [SerializeField]
    private Canvas screen;

    private ConfirmButtons confirmationScreen;

    private void Start()
    {
        confirmationScreen = screen.GetComponent<ConfirmButtons>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ElementInfo>().GetElementName()
            == "Hydrogen")
        {
            confirmationScreen.PopUp();
            //Debug.Log("works");
        }
    }
}
