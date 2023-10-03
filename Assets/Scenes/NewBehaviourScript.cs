using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Testobj;

    public void button() {
        if (Testobj.activeSelf)
            Testobj.SetActive(false);
        else Testobj.SetActive(true);
      
    }
}
