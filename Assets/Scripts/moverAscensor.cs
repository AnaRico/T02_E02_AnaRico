using UnityEngine;
using System.Collections;

public class moverAscensor : MonoBehaviour {
	
	[SerializeField]
	private GameObject ascensor;
	private Animation animacionAscensor;
	private GameObject jugador;
	private inventario2 inven;
	
	void Start () {
		
		animacionAscensor = ascensor.GetComponent<Animation> ();
		jugador = GameObject.Find ("Jugador") as GameObject;
		inven = jugador.GetComponent<inventario2> ();
	}
	
	void OnTriggerEnter(Collider collider){
		if (inven.inventario2Boton) {
				//Debug.Log("hola");
				animacionAscensor.Play ("subirAscensor");
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
