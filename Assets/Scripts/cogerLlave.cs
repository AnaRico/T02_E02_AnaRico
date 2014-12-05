using UnityEngine;
using System.Collections;

public class cogerLlave : MonoBehaviour {

	[SerializeField]
	private GameObject llave;
	private GameObject jugador;
	private inventario invent;
	

	// Use this for initialization
	void Start () {
		jugador = GameObject.Find ("Jugador") as GameObject;
		llave = GameObject.Find ("GO_llave") as GameObject;
		invent = jugador.GetComponent<inventario>();
	}

	void OnTriggerEnter(Collider collider) 
	{
		Debug.Log (invent.inventarioLlave);
		invent.inventarioLlave = true; 
		Destroy (this.llave);  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
