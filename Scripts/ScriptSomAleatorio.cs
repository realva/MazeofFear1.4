// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptSomAleatorio : MonoBehaviour {

	public AudioClip[] listaAudios;
	private float cronometroDeAudios, sorteioTempo;
	private bool cronometrar;
	private int sorteioAudio;
	public float tempoDeEspera;


	// Start é chamada na inicialização.
	// Responsável por executar sons aleatórios durante o percurso do labirinto.
	void Start () {

		sorteioAudio = Random.Range (0, listaAudios.Length);
		AudioSource audios = GetComponent<AudioSource> ();
		audios.clip = listaAudios [sorteioAudio];
		sorteioTempo = Random.Range (listaAudios [sorteioAudio].length, (listaAudios [sorteioAudio].length + tempoDeEspera));
		cronometrar = true;

	}
	
	// Update é chamada a cada frame na execução.
	void Update () {

		if (cronometrar == true) {
			cronometroDeAudios += Time.deltaTime;
		}
		if (cronometroDeAudios >= sorteioTempo) {
			cronometrar = false;
			cronometroDeAudios = 0;
			sorteioAudio = Random.Range (0, listaAudios.Length);
			AudioSource audios = GetComponent<AudioSource> ();
			audios.clip = listaAudios [sorteioAudio];
			sorteioTempo = Random.Range (listaAudios [sorteioAudio].length, (listaAudios [sorteioAudio].length + tempoDeEspera));
			TocarSom ();
		}
			
	}

	void TocarSom () {

		GetComponent<AudioSource>().PlayOneShot(listaAudios[sorteioAudio]);
		cronometrar = true;
	}

}
