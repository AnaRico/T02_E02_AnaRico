using UnityEngine;
using System.Collections;

public class pulsarBoton : MonoBehaviour {
	
	[SerializeField]
	private GameObject boton;
	private GameObject jugador;
	private inventario2 invent;
	
	
	// Use this for initialization
	void Start () {
		jugador = GameObject.Find ("Jugador") as GameObject;
		boton = GameObject.Find ("GO_boton") as GameObject;
		invent = jugador.GetComponent<inventario2>();
	}
	
	void OnTriggerEnter(Collider collider) 
	{
		Debug.Log (invent.inventario2Boton);
		invent.inventario2Boton = true; 
		//Destroy (this.boton);  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
