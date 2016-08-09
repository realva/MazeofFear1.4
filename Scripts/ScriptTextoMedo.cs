// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class ScriptTextoMedo : MonoBehaviour {
	
	public Font fonte;
	public static int medo;
	public int cont;

	// Start é chamada na inicialização.
	void Start () {
		cont = 0;
		medo = 0;
	
	}

	// Update é chamada a cada frame na execução.
	void Update () {


		if (medo >= 100 && cont <= 180) {
			
			medo = 100;
			if(cont == 180)							//gambiarra
				Application.LoadLevel ("TelaMorte");
			cont++;
		}
	
	}
	void OnGUI(){		//criando e posicionando texto com porcentagem de medo
		GUI.skin.font = fonte;		
		GUI.skin.label.fontSize = Screen.height / 40;
		GUI.Label (new Rect (Screen.width / 2 - Screen.width /2.1f, Screen.height / 1 - Screen.height / 11, Screen.width / 2.5f, Screen.height / 10),"Medo: " + medo.ToString() +"%" );
	}
}

