using UnityEngine;
using System.Collections;

public class abrirPuerta : MonoBehaviour {

	[SerializeField]
	private GameObject puerta;
	private Animation animacionPuerta;
	private GameObject jugador;
	private inventario inven;

	void Start () {
	
		animacionPuerta = puerta.GetComponent<Animation> ();
		jugador = GameObject.Find ("Jugador") as GameObject;
		inven = jugador.GetComponent<inventario> ();
	}
	
	void OnTriggerEnter(Collider collider){
		if (inven.inventarioLlave) {
			animacionPuerta.Play ("moverPuerta");
				}
	}
}
