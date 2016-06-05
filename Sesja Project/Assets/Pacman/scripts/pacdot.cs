using UnityEngine;
using System.Collections;

public class pacdot : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "pacman") {
			Destroy(gameObject);
		}
			
	}
}
