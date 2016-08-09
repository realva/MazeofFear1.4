// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptSusto01 : MonoBehaviour {

	private BoxCollider[] colisores;
	public AudioClip audioSusto;
	private float cronometro;
	public float tempoDaImagem;
	private bool ativaCronometro;

	// Start é chamada na inicialização.
	void Start () {

		GetComponent<Renderer>().enabled = false;
		colisores = gameObject.GetComponents<BoxCollider>();
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioSusto;

	
	}
	
	// Update é chamada a cada frame na execução.
	void Update () {

		if (ativaCronometro == true) {
			cronometro += Time.deltaTime;
		}
		if (cronometro >= tempoDaImagem) {
			ativaCronometro = false;
			GetComponent<Renderer> ().enabled = false;
		}
	}
	// Trigger que irá acionar o susto.
	void OnTriggerEnter() {

		ativaCronometro = true;
		GetComponent<Renderer>().enabled = true;
		GetComponent<AudioSource>().PlayOneShot(audioSusto);
		foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = false;
		}
		ScriptTextoMedo.medo += 30;
		Destroy(gameObject, audioSusto.length);

	}
}
