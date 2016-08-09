// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;

public class ScriptTelaFInal : MonoBehaviour {

	public Font fonte;

	// Start é chamada na inicialização.
	void Start () {
	
	}
	
	// Update é chamada a cada frame na execução.
	void Update () {
	
	}

	void OnGUI(){		//criando e posicionando texto com porcentagem da bateria
		GUI.skin.font = fonte;		
		GUI.skin.label.fontSize = Screen.height / 30;
		GUI.Label (new Rect (Screen.width / 2 - Screen.width / 2.1f, Screen.height / 1 - Screen.height * 0.95f, Screen.width / 2.5f, Screen.height / 10), "Você finalizou o labirinto com o tempo " + ScriptTextoTempo.tempo.Minutes + ":" + ScriptTextoTempo.tempo.Seconds );
	}
}
