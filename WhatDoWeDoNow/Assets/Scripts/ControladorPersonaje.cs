using UnityEngine;
using System.Collections;

public class ControladorPersonaje : MonoBehaviour {

	public float fuerzasalto = 0.3f;
	public Rigidbody2D Personaje;
	private bool caminando = false;
	private bool saltando = false;
	private bool corriendo = false;
	private bool volteaIzq = false;
	private bool volteaDer = true;
	public float velociad = 3f;
	private Vector3 posicion;
	
	private Animator animator;

	public GameObject InicioEscena;
	public GameObject FinEscena;


	void Awake ()
	{
		animator = GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () 
	{
		PosicionarJugador();
	}

	//Ubicar al jugador
	public GameObject posicionJugador;

	void PosicionarJugador()
	{

		float altura;
		altura = posicionJugador.transform.position.y + (transform.localScale.y / 2.0f) + 1.2f;

		transform.position = new Vector3(posicionJugador.transform.position.x,
		                                 altura,
		                                 posicionJugador.transform.position.z);
	}

	void FixedUpdate(){

		animator.SetBool ("KeyWalk", caminando);
		animator.SetBool ("KeyJump", saltando);
		animator.SetBool("KeyRun",corriendo);

		caminando = false;
		saltando = false;
		corriendo = false;

	}

	void LateUpdate()
	{
		Carril();
	}

	//Función para evitar que pase de la escena
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

	void Update () {

		if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Translate (velociad * Time.deltaTime,0f,0f,Space.World);
			if(volteaIzq)
			{
				this.transform.Rotate (0f,180f,0f,Space.Self);
				volteaIzq = false;
				volteaDer = true;
			}
			caminando = true;

		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Translate (-velociad * Time.deltaTime,0f,0f,Space.World);
			if(volteaDer)
			{
				this.transform.Rotate (0f,180f,0f,Space.Self);
				volteaDer = false;
				volteaIzq = true;
			}
			caminando = true;
		}
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			//No salta :(
			Personaje.transform.Translate(0f,fuerzasalto,0f,Space.World);
			saltando = true;
		}
		if(Input.GetKey(KeyCode.Space))
		{
			if(volteaDer)
				this.transform.Translate((velociad*2)*Time.deltaTime,0f,0f,Space.World);
			if(volteaIzq)
				this.transform.Translate((-velociad*2)*Time.deltaTime,0f,0f,Space.World);

			corriendo = true;
		}


	}
}
