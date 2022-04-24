using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ConfirmButtons : MonoBehaviour
{
    [SerializeField]
    private UnityEditor.SceneAsset scene;

    [SerializeField]
    private TextMeshProUGUI confirmMatchText;

    public void PopUp(string elementOne, string elementTwo, UnityEditor.SceneAsset chosenScene)
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;

        confirmMatchText.text = "Do you want to bond " + elementOne +
            " and " + elementTwo + "?";

        scene = chosenScene;
        Debug.Log(chosenScene);
    }

    public void YesButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scene.name);
    }

    public void NoButton()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
