using UnityEngine;
using System.Collections;

[RequireComponent(typeof(HealthSystem))]
public class Player : MonoBehaviour {

	public float WalkSpeed = 2.0f;
	public GameObject BloodParticlePrefab;

	private Animator animator;
	private HealthSystem healthSystem;

	void Start() {
		animator = GetComponent<Animator> ();
		healthSystem = GetComponent<HealthSystem> ();
	}
	
	void Update () {
		if (healthSystem.IsAlive) {
			var horizontal = Input.GetAxisRaw ("Horizontal");
			var vertical = Input.GetAxisRaw ("Vertical");
			var isWalking = horizontal != 0 || vertical != 0;

			animator.SetBool ("IsWalking", isWalking);
			if (isWalking) {
				animator.SetFloat ("XVelocity", horizontal);
				animator.SetFloat ("YVelocity", vertical);
			}

			transform.Translate (new Vector2 (horizontal, vertical) * WalkSpeed * Time.deltaTime);
		}
	}

	void OnTakeDamage(int amount) {
		Instantiate (BloodParticlePrefab, transform.position, Quaternion.identity);
	}

	void OnDeath() {
		animator.SetBool ("IsWalking", false);
		transform.Rotate (0f, 0f, 90f);
	}

}
