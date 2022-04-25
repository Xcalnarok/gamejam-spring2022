using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Element", menuName = "Element Info")]
public class ElementSO : ScriptableObject
{
    public string elementName;
    public List<string> scenes;

    public List<string> bondableElements;
        

    public bool readyToBond;

    private void Awake()
    {
        readyToBond = false;
    }

    //public List<string> scenes;
}
