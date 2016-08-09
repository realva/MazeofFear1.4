// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptSomBateria : MonoBehaviour {

	private BoxCollider[] colisores;
	public AudioClip audioBateria;

	// Start é chamada na inicialização.
	void Start () {
		colisores = gameObject.GetComponents<BoxCollider> ();
	
	}
	
	// Update é chamada a cada frame na execução.
	void Update () {
	
	}

	void OnTriggerEnter(){

		GetComponent<AudioSource> ().PlayOneShot (audioBateria);
		foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = false;
		}
		Destroy (gameObject, audioBateria.length);

	}
}
