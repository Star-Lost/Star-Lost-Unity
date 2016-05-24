using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float WalkSpeed = 2.0f;

	private Animator animator;

	void Start() {
		animator = GetComponent<Animator> ();
	}
	
	void Update () {
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
