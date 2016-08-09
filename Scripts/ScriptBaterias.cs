// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
//[RequireComponent(typeof(AudioSource))]

public class ScriptBaterias : MonoBehaviour {

	public float recarga;
	//public AudioClip audioBateria;
	public GameObject Bateria;
	private bool EstaNoLocal;
	public Font fonte;

	// Start é chamada na inicialização.
	// Atribui o valor de recarga para cada bateria.
	void Start () {
		EstaNoLocal = false;

	}

	// Update é chamada a cada frame na execução.
	// Mantêm as baterias rotacionando no eixo y constantemente.
	void Update () {
		if (Input.GetKeyDown (KeyCode.E) && EstaNoLocal == true) {
			//GetComponent<AudioSource> ().PlayOneShot (audioBateria);
			if (ScriptLigarLanterna.bateria + recarga > ScriptLigarLanterna.bateriaCheia) {		//if para evitar que bateria fique com mais de 100%
				ScriptLigarLanterna.bateria = ScriptLigarLanterna.bateriaCheia;
			} else {
				ScriptLigarLanterna.bateria += recarga;
			}
			Destroy(Bateria);
		}
		Bateria.transform.Rotate(0, 5, 0, Space.World);

	}
		
	void OnTriggerEnter() {
		EstaNoLocal = true;


	}

	void OnTriggerExit(){
		EstaNoLocal = false;
	}

	void OnGUI(){
		GUI.skin.font = fonte;
		GUI.skin.label.fontSize = Screen.height / 20;
		if (EstaNoLocal == true) {
			GUI.Label (new Rect (Screen.width / 2 - Screen.width / 5, Screen.height / 2 - Screen.height / 16, Screen.width / 2.5f, Screen.height / 8),"Aperte 'E' para pegar a bateria" );

		}
	}

}