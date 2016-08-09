// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptTelaFinalReiniciar : MonoBehaviour {

	public Button voltarInicialB;
	public Button sairB;

	// Start é chamada na inicialização.
	void Start () {
		//O objeto Cursor permite a visualização do cursor do mouse na tela final do jogo.
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

		voltarInicialB.onClick.AddListener(()=> {
			Application.LoadLevel("TelaInicial");	// Ação de retorno a tela inicial.
		});

		sairB.onClick.AddListener (() => {
			Application.Quit();  // Ação de saída do jogo.
		});


	
	}
	
	// Update é chamada a cada frame na execução.
	void Update () {
		

	}
}
