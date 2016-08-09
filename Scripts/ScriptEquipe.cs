// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptEquipe : MonoBehaviour {

	public Button voltarB;

	// Start é chamada na inicialização.
	void Start () {

		voltarB.onClick.AddListener(()=> {
			Application.LoadLevel("TelaInicial"); // Transfere o fluxo para a cena TelaInicial.	
		});

	}
	
	// Update é chamada a cada frame computado.
	void Update () {
	
	}
}
