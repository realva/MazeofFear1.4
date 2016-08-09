// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptPorta : MonoBehaviour {

	public AudioClip audioPortaFechada;
	public AudioClip audioPortaAbrindo;
	public GameObject porta;
	private bool estaNoLocal;
	private bool abrirPorta;
	public Font fonte;
	public int cont;

	// Start é chamada na inicialização.
	void Start () {
		estaNoLocal = false;
		abrirPorta = false;
		cont = 0;
	}

	// Update é chamada a cada frame na execução.
	// Controla ações executadas na porta final do jogo.
	void Update () {
		if (Input.GetKeyDown ("e") && estaNoLocal == true && abrirPorta == false) {
			GetComponent<AudioSource> ().PlayOneShot (audioPortaAbrindo);
			abrirPorta = true;
		}

		if (abrirPorta == true && cont < 180) {
			porta.transform.Rotate(0, -0.5f, 0, Space.World);
			cont++;
		}

	}

	void OnTriggerEnter() {
		estaNoLocal = true;
	}

	void OnTriggerExit(){
		estaNoLocal = false;
	}

	void OnGUI(){
		GUI.skin.font = fonte;
		GUI.skin.label.fontSize = Screen.height / 20;
		if (estaNoLocal == true) {
			GUI.Label (new Rect (Screen.width / 2 - Screen.width / 5, Screen.height / 2 - Screen.height / 16, Screen.width / 2.5f, Screen.height / 8),"Aperte 'E' para abrir a porta" );

		}
	}
}
