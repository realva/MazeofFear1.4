// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptMenu : MonoBehaviour {

	public Button iniciarB;
	public Button sairB;
	public Button equipeB;
	public Button sobreJogoB;

	// Start é chamada na inicialização.
	void Start () {

		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

		iniciarB.onClick.AddListener(()=> {
			Application.LoadLevel("MazeofFear01");	// Ação para o inicio do jogo.
		});

		sairB.onClick.AddListener (() => { // Ação para sair do jogo.
			Application.Quit();
		});

		equipeB.onClick.AddListener(()=> {
			Application.LoadLevel("TelaEquipe");	// Ação para tela sobre a equipe de desenvolvimento.
		});

		sobreJogoB.onClick.AddListener(()=> {
			Application.LoadLevel("TelaSobreoJogo");	// Ação para tela a cerca das intruções do jogo.
		});


	}
	
	// Update é chamada a cada frame na execução.
	void Update () {

	}
}
