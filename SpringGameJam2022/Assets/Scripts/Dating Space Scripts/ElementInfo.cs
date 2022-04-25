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

    //public UnityEditor.SceneAsset GetElementScene(int num)
    //{
    //    return elementInfo.scenes[num];
    //}
    public string GetElementScene(int num)
    {
        return elementInfo.scenes[num];
    }

    public bool CheckIfPossibleElement(string element)
    {
        return elementInfo.bondableElements.Contains(element);
    }

    public bool BondReady()
    {
        return elementInfo.readyToBond;
    }

    public void SetBondOn()
    {
        elementInfo.readyToBond = true;
    }

    public void SetBondOff()
    {
        elementInfo.readyToBond = false;
    }
}
