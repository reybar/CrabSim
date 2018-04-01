using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {


    Gyroscope myGyro;



	// Use this for initialization
	void Start () {
       

        myGyro = Input.gyro;
        myGyro.enabled = true;

        transform.rotation = new Quaternion(0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 previousEulerAngles = transform.eulerAngles;
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased;

        Vector3 targetEulerAngles = previousEulerAngles + gyroInput * Time.deltaTime * Mathf.Rad2Deg;
        targetEulerAngles.x = 0.0f; // Only this line has been added
        targetEulerAngles.y = 0.0f;

        transform.eulerAngles = targetEulerAngles;
	}
    void OnMouseDown() {
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    
}
