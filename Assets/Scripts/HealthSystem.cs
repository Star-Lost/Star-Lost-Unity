using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

	public int MaxHealth = 100;
	public int Health = 100;
	public bool IsAlive = true;

	public void TakeDamage(int amount) {
		Health -= amount;
		SendMessage ("OnTakeDamage", amount);

		if (Health <= 0) {
			IsAlive = false;
			SendMessage ("OnDeath");
		}
	}

}
