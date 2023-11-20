using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Testobject;

    public void ToggleObject()
    {
        if (Testobject.activeSelf)
        {
            Testobject.SetActive(false);
        }
        else
        {
            Testobject.SetActive(true);
        }
    }
}
