using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nuage : MonoBehaviour
{
    public GameObject nuage;
    public Button leBoutton;

    // Start is called before the first frame update
    void Start()
    {
       leBoutton.onClick.AddListener(OffOn);
    }

    void OffOn()
    {
        if (nuage.active == true)
        {
            nuage.active = false;
        }
        else 
        {
            nuage.active = true;
        }
    }
}
