using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TriggerFlip : MonoBehaviour
{

    public GameObject button;
    public Animation flip;
    public Animation idle;

    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(ButtonAppuyer);
    }

    //action lorsque le button est appuyer
    void ButtonAppuyer(VirtualButtonBehaviour vb) 
    {
        idle["Rotation"].speed = 0;
        flip.Play("Flip");
    }
    public void FinFlip()
    {
        idle["Rotation"].speed = 1;
    }
}
