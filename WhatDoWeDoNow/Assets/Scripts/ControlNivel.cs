using UnityEngine;
using System.Collections;

public class ControlNivel : MonoBehaviour {

	public GameObject Player;
	public GameObject PosicionInicial;

	// Use this for initialization
	void Start () {
		PosicionarJugador();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PosicionarJugador()
	{
		Player.transform.position = new Vector3(PosicionInicial.transform.position.x, PosicionInicial.transform.position.y, PosicionInicial.transform.position.z);
	}

}
