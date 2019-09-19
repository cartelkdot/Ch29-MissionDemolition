using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    public GameObject launchpoint;
  

   
     // fields set in the Unity Inspector pane
    [Header("Set in Inspector")]


    // fields set dynamically
    [Header("Set Dynamically")]



    private void Awake()
    {

    }

    private void OnMouseEnter()
    {
        print("Slingshot:OnMouseEnter()");
    }

    private void OnMouseExit()
    {
        print("Slingshot:OnMouseEnter()");
    }

    private void OnMouseDown()
    {

    }

    private void Update()
    {
 


    }
}
