using UnityEngine;
using System.Collections;

public class ControlCamera : MonoBehaviour {

	public GameObject Player;
	public float Velocidad;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(Player.transform.position.x,
		                                 transform.position.y,
		                                 transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

	}


}
