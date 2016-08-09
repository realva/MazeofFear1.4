// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;

public class ScriptLanternaAux : MonoBehaviour {

	public bool ligar;
	private float intensidade;
	// Start é chamada na inicialização.
	void Start () {

		ligar = false;
		intensidade = GetComponent<Light>().intensity;
	
	}
	
	// Update é chamada a cada frame na execução.
	// Responsável por ligar a lanterna.
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			ligar = !ligar;
			if (ligar == false) {
				GetComponent<Light> ().intensity = 0;
			} else {
				GetComponent<Light>().intensity = intensidade;
			}
		}
	}
}
