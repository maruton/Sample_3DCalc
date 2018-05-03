using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCalc : MonoBehaviour {


	public GameObject TargetShip;


	void testFunc() {
		// Calc distance
		float dist = Vector3.Distance(TargetShip.transform.position, transform.position);

		// Calc Sight Range degree
		Vector3 targetDir = TargetShip.transform.position - transform.position;
		float angle = Vector3.Angle(targetDir, transform.forward);

		// Front=Z+  
		Debug.Log("dist=" + dist + "  angle=" + angle);
	}


	void Start () {
		
	}


	void Update () {
		testFunc();
	}
}
