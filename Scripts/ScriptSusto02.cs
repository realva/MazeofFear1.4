// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptSusto02 : MonoBehaviour {

	public AudioClip audioSusto;
	public float velocidadeMovimento;
	private float cronometro;
	public float tempoDestruir;
	public GameObject meshMonstro;
	private BoxCollider[] colisores;
	private bool mover;

	// Start é chamada na inicialização.
	void Start () {

		colisores = gameObject.GetComponents<BoxCollider>();
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioSusto;
		meshMonstro.GetComponent<Renderer>().enabled = false;

	}
	
	// Update é chamada a cada frame na execução.
	void Update () {

		if (mover == true) {
			transform.Translate (Vector3.forward * Time.deltaTime * velocidadeMovimento);
			cronometro += Time.deltaTime;
		}
		if (cronometro >= tempoDestruir) {
			mover = false;
			meshMonstro.GetComponent<Renderer>().enabled = false;
		}
	}
	// Trigger que irá acionar o susto.	
	void OnTriggerEnter() {
		meshMonstro.GetComponent<Renderer>().enabled = true;
		foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = false;
		}
		GetComponent<AudioSource>().PlayOneShot(audioSusto);
		ScriptTextoMedo.medo += 30;
		Destroy(gameObject, audioSusto.length);
		mover = true;

	}
}
