// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptSobreoJogo : MonoBehaviour {

	public Button voltarB;

	// Start é chamada na inicialização.
	void Start () {

		voltarB.onClick.AddListener(()=> {
			Application.LoadLevel("TelaInicial"); // Controle de fluxo para a tela iniciar decorrente do evento,	
		});

	}

	// Update é chamada a cada frame na execução.
	void Update () {

	}
}
