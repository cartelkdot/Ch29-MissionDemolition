using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {




    // fields set in the Unity Inspector pane
    [Header("Set in Inspector")]
    public GameObject prefabProjectile;

    // fields set dynamically
    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;


    private void Awake()
    {
        Transform launchPointTrans = transform.FindChild("LaunchPoint");
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
