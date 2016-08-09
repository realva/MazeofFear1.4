// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class ScriptTextoTempo : MonoBehaviour {

	public Font fonte;
	public int minutos;
	public int segundos;
	Stopwatch timer = new Stopwatch();
	public static TimeSpan tempo;

	// Use this for initialization
	void Start () {
		segundos = 0;
		minutos = 0;
		timer.Start ();
	
	}

	// Update is called once per frame
	void Update () {
		/*segundos += (int)timer;
		if (segundos == 60) {
			segundos = 0;
			minutos += 1;
		}*/
	
	}
	void OnGUI(){		//criando e posicionando texto com tempo.
		tempo = timer.Elapsed;
		GUI.skin.font = fonte;		
		GUI.skin.label.fontSize = Screen.height / 40;
		GUI.Label (new Rect (Screen.width / 2 - Screen.width / 2.1f, Screen.height / 1 - Screen.height * 0.95f, Screen.width / 2.5f, Screen.height / 10), "Tempo: " + tempo.Minutes + ":" + tempo.Seconds );
	}
}
