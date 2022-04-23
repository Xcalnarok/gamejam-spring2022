using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	public void ChangeScene(UnityEditor.SceneAsset sceneObject)
	{
		string sceneName = sceneObject.name;
		SceneManager.LoadScene(sceneName);
	}
	//	public void ChangeScene(string sceneName)
	//	{
	//		SceneManager.LoadScene(name);
	//	}
	public void Exit()
	{
		Application.Quit();
	}
}
