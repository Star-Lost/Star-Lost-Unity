using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		var healthSystem = collider.GetComponent<HealthSystem> ();
		if (healthSystem == null)
			return;

		healthSystem.TakeDamage (100);
	}

}
