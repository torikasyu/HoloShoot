using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class GameManager : MonoBehaviour, IInputClickHandler {

    //public Camera myCamera;
    public GameObject bulletPrefab;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("fire");

        //throw new NotImplementedException();

        //Vector3 shootDir = myCamera.transform.forward.normalized;
        Vector3 shootDir = transform.forward;

        GameObject bullet = Instantiate(this.bulletPrefab);
        Rigidbody rid = bullet.GetComponent<Rigidbody>();
        rid.AddForce(shootDir * 100.0f);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
