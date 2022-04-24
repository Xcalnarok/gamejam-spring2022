using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ConfirmButtons : MonoBehaviour
{

    public void PopUp()
    {

        Debug.Log("please");
        gameObject.SetActive(true);
        //Time.timeScale = 0;

    }


    public void YesButton()
    {

    }

    public void NoButton()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
