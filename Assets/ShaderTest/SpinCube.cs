using UnityEngine;
using System.Collections;

public class SpinCube : MonoBehaviour {
	void Update () {
		transform.RotateAround (Vector3.up, .3f * Time.deltaTime);
	}
}
