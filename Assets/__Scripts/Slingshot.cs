using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    public GameObject launchPoint;
  

   
     // fields set in the Unity Inspector pane
    [Header("Set in Inspector")]


    // fields set dynamically
    [Header("Set Dynamically")]



    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPointTrans = launchPointTrans.gameObject;
        launchPoint.SetActive(false);

    }

    private void OnMouseEnter()
    {

        //rint("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);
    }

    private void OnMouseExit()
    {
        //print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(false);
    }

    private void OnMouseDown()
    {

    }

    private void Update()
    {
 


    }
}
