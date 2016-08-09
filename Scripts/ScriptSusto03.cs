// Trabalho Computação Gráfica 2016.1
using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ScriptSusto03 : MonoBehaviour {

	public GameObject Monstro;
	public GameObject meshMonstro;
	public Light luzSusto, luzPlayer;
	public AudioClip audioLuz;
	private BoxCollider[] colisores;
	public AudioClip audioMonstro;

	// Use this for initialization
	void Start () {

		luzSusto.enabled = true;
		meshMonstro.GetComponent<Renderer>().enabled = false;
		colisores = GetComponents<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnTriggerEnter(){

		luzPlayer.enabled = false;
		GetComponent<AudioSource>().PlayOneShot(audioLuz);
		foreach (BoxCollider BoxColl in colisores) {
			BoxColl.enabled = false;
		}
		ScriptTextoMedo.medo += 30;
		yield return new WaitForSeconds (0.3f);
		luzSusto.enabled = false;
		yield return new WaitForSeconds (0.3f);
		luzSusto.enabled = true;
		yield return new WaitForSeconds (0.2f);
		luzSusto.enabled = false;
		yield return new WaitForSeconds (0.2f);
		luzSusto.enabled = true;
		yield return new WaitForSeconds (0.3f);
		luzSusto.enabled = false;
		yield return new WaitForSeconds (0.1f);
		luzSusto.enabled = true;
		yield return new WaitForSeconds (0.3f);
		luzSusto.enabled = false;
		yield return new WaitForSeconds (0.2f);
		luzSusto.enabled = true;
		yield return new WaitForSeconds (0.2f);
		luzSusto.enabled = false;
		GetComponent<AudioSource>().PlayOneShot(audioMonstro);
		yield return new WaitForSeconds (0.3f);
		luzSusto.enabled = true;
		yield return new WaitForSeconds (0.3f);
		luzSusto.enabled = true;
		meshMonstro.GetComponent<Renderer>().enabled = true;
		yield return new WaitForSeconds (1f);
		luzSusto.enabled = false;
		meshMonstro.GetComponent<Renderer>().enabled = false;

		luzPlayer.enabled = true;

		Destroy (luzSusto);
		Destroy (Monstro);
		Destroy (gameObject);
	}
}
