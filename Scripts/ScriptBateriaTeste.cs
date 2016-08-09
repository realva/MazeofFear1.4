// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
//[RequireComponent(typeof(AudioSource))]

public class ScriptBateriaTeste : MonoBehaviour {

	public BoxCollider[] colisores;
	public float recarga;
	//public AudioClip audioBateria;
	public GameObject Bateria;
	public GameObject CorpoBateria01;
	public GameObject CorpoBateria02;
	public GameObject PinoBateria;
	public Light luzBateira;
	private bool mapaAtivo;

	// Start é chamada na inicialização.
	// Atribui o valor de recarga para cada bateria.
	void Start () {

		colisores = gameObject.GetComponents<BoxCollider>();
		mapaAtivo = false;

	}

	// Update é chamada a cada frame na execução.
	// Mantêm as baterias rotacionando no eixo y constantemente.
	void Update () {
		
		Bateria.transform.Rotate(0, 5, 0, Space.World);

		if(Input.GetKeyDown(KeyCode.M)){
			mapaAtivo = !mapaAtivo;
			CorpoBateria01.GetComponent<Renderer> ().enabled = !mapaAtivo;
			CorpoBateria02.GetComponent<Renderer> ().enabled = !mapaAtivo;
			PinoBateria.GetComponent<Renderer> ().enabled = !mapaAtivo;
			luzBateira.enabled = !mapaAtivo;
		}
	}

	void OnTriggerEnter() {

		foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = false;
		}
		if (ScriptLigarLanterna.bateria + recarga > ScriptLigarLanterna.bateriaCheia) {		//if para evitar que bateria fique com mais de 100%
			ScriptLigarLanterna.bateria = ScriptLigarLanterna.bateriaCheia;
		} else {
			ScriptLigarLanterna.bateria += recarga;
		}
        //GetComponent<AudioSource>().PlayOneShot(audioBateria);
		//Bateria.GetComponent<Renderer>().enabled = false;
		//Bateria.GetComponent<BoxCollider>().enabled = false;
		Destroy(gameObject);

	}
}
