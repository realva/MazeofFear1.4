// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class ScriptTextoBateria : MonoBehaviour {

	public Font fonte;
	public static float carga;

	// Start é chamada na inicialização.
	void Start () {
	}

	// Update é chamada a cada frame na execução.
	// De acordo com o tempo diminui a carga da bateria identificada pelo texto na interface do usuário.
	void Update () {

		carga = 100 - (((ScriptLigarLanterna.bateriaCheia - ScriptLigarLanterna.bateria)/ ScriptLigarLanterna.bateriaCheia) * 100); //porcentagem da bateria
		carga = (int)(carga);

	

	}

	void OnGUI(){		//criando e posicionando texto com porcentagem da bateria
		GUI.skin.font = fonte;		
		GUI.skin.label.fontSize = Screen.height / 40;
		GUI.Label (new Rect (Screen.width / 2 - Screen.width /2.1f, Screen.height / 1 - Screen.height / 16, Screen.width / 2.5f, Screen.height / 10),"Bateria: " + carga.ToString() +"%" );
	}
}