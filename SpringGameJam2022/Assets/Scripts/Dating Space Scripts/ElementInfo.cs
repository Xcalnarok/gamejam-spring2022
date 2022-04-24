using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementInfo : MonoBehaviour
{
    [SerializeField]
    private ElementSO elementInfo;

    public string GetElementName()
    {
        return elementInfo.elementName;
    }
}
