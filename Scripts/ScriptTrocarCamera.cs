// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;

public class ScriptTrocarCamera : MonoBehaviour {
	
	public Camera cameraPlayer;
	public Camera cameraMapa;
	private bool mapaAtivo;
	public Light directLight;
	public GameObject Baterias;



	// Start é chamada na inicialização.
	// Ao iniciar o programa a unica camera ativa será a do jogador.
	void Start () {

		cameraPlayer.enabled = true;
		cameraMapa.enabled = false;
		mapaAtivo = false;

	
	}
	
	// Update é chamada a cada frame na execução.
	void Update () {
		// Uma vez a tecla M é pressionada inverte-se a ativação das cameras para a visualização do mapa.
		if(Input.GetKeyDown(KeyCode.M)){
			mapaAtivo = !mapaAtivo;
			cameraMapa.enabled = mapaAtivo;
			cameraPlayer.enabled = !mapaAtivo;
			directLight.enabled = mapaAtivo;
		}
	
	}
}
