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

		Camera myCamera = GetComponent<Camera> ();
        Vector3 shootDir = myCamera.transform.forward.normalized;
		print (shootDir.x.ToString () + ":" + shootDir.y.ToString () + ":" + shootDir.z.ToString ());
        //Vector3 shootDir = transform.forward;

        GameObject bullet = Instantiate(this.bulletPrefab);
		bullet.transform.position = new Vector3 (myCamera.transform.position.x, myCamera.transform.position.y + 0.5f, myCamera.transform.position.z);
        Rigidbody rid = bullet.GetComponent<Rigidbody>();
        rid.AddForce(shootDir * 500.0f);

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
