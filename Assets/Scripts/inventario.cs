using UnityEngine;
using System.Collections;

public class inventario : MonoBehaviour {

	[SerializeField]
	private bool _llave;

	public bool inventarioLlave{
		get {return _llave; }
		set {_llave = value; }
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
