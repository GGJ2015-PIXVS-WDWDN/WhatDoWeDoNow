using UnityEngine;
using System.Collections;

public class ControlCamera : MonoBehaviour {

	public GameObject posicionJugador;
	public float Velocidad;
	public GameObject jugador;
	public float distanciaCamara;
	private float division;
		
	// Use this for initialization
	void Start () 
	{
		this.division = distanciaCamara / 2.0f;
		PosicionarCamara();
	}

	public void PosicionarCamara()
	{
		transform.position = new Vector3(posicionJugador.transform.position.x,
		                                transform.position.y,
		                                transform.position.z);


	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate(Velocidad * Time.deltaTime, 0.0f, 0.0f, Space.World);

			//this.transform.Translate((Velociad*2.0f)*Time.deltaTime,0f,0f,Space.World);
			//transform.Translate(Vector3.left * Velocidad * Time.deltaTime, Space.World);
			Debug.Log ("Muevo camara");
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate(-Velocidad * Time.deltaTime, 0.0f, 0.0f, Space.World);

			//this.transform.Translate((Velociad*2.0f)*Time.deltaTime,0f,0f,Space.World);
			//transform.Translate(Vector3.left * Velocidad * Time.deltaTime, Space.World);
			Debug.Log ("Muevo camara");
		}
	}

	public GameObject InicioEscena;
	public GameObject FinEscena;

	void Carril()
	{
		
		if(transform.position.x > InicioEscena.transform.position.x)
		{
			transform.position = new Vector3(InicioEscena.transform.position.x,
			                                 transform.position.y, 
			                                 transform.position.z);


			
		}
		
		if(transform.position.x < FinEscena.transform.position.x)
		{
			transform.position = new Vector3(FinEscena.transform.position.x,
			                                 transform.position.y, 
			                                 transform.position.z);


		}


	}

	void LateUpdate()
	{
		Carril();

	}

}
