using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Element", menuName = "Element Info")]
public class ElementSO : ScriptableObject
{
    public string elementName;
    public string sceneName;

    public bool readyToBond;

    private void Awake()
    {
        readyToBond = false;
    }

    public void SetBondOn()
    {
        readyToBond = true;
    }

    public void SetBondOff()
    {
        readyToBond = false;
    }

    //public List<string> scenes;
}
