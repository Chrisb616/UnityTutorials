using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerRotate : MonoBehaviour {

	public int speed;

	void Update () {
		transform.Rotate (new Vector3 (0, 20, 0) * Time.deltaTime * speed);
	}
}
