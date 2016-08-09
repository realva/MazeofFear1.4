// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptLigarLanterna : MonoBehaviour {

	private bool ligar;
	private bool aviso;
	private float intensidade;
	private float intensidadeInicial;
	public static float bateria;
	public static float bateriaCheia;
	public int bateriaInicial;
	public AudioClip audioLanterna;
	public Light iluminacaoLanterna;
	public Font fonte;



	// Start é chamada na inicialização.
	// Inicia o jogo com a lanterna ligada, com seu máximo de bateria e sua intensidade adequada.
	void Start () {

		aviso = true;
		ligar = false;
		bateria = bateriaInicial;
		bateriaCheia = bateriaInicial;
		intensidade = GetComponent<Light>().intensity;
		intensidadeInicial = intensidade;
	
	}
	
	// Update é chamada a cada frame na execução.
	// Atribui os gasto da bateria da lanterna, assim como seus estados de ligada e desligada.
	void Update () {
		if(Input.GetKeyDown(KeyCode.F)){
			aviso = false;
			ligar = !ligar;
			GetComponent<AudioSource>().PlayOneShot(audioLanterna);
		}
		// Caso a lanterna esteja ligada, a intensidade da luz irá diminuir de acordo com o tempo.
		if(ligar == true){
			Debug.Log(bateria);
			Debug.Log(intensidade);
			Debug.Log(bateriaInicial);
			intensidade = intensidadeInicial *  (1 - ((bateriaInicial - bateria)/bateriaInicial) );
			GetComponent<Light>().intensity = intensidade;
			if (intensidade <= 0) {
				iluminacaoLanterna.intensity = 0;
				Application.LoadLevel("TelaMorte");
			}
		}
		else{
			GetComponent<Light>().intensity = 0;
		}
		if(bateria <= 0){
		    ligar = false;
			GetComponent<Light>().intensity = 0;
		}
		// Diminui carga da bateria ao longo do tempo caso a lanterna esteja ligada.
		if(bateria > 0 && ligar == true){             
			bateria = bateria -1;
		}
	
	}
	void OnGUI(){
		GUI.skin.font = fonte;
		GUI.skin.label.fontSize = Screen.height / 20;
		if (aviso == true) {
			GUI.Label (new Rect (Screen.width / 2 - Screen.width / 5, Screen.height / 2 - Screen.height / 16, Screen.width / 2.5f, Screen.height / 8), "Aperte 'F' para ligar a lanterna");
		}
	}
}
