using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class InicioGUI : MonoBehaviour 
{

	public Button[] botones;
	private int cantidadBotones;
	//public int[] nivelCarga;
	
	//public GUIStyle estilo;
	//public GUISkin skin;
	//public GenericButton[] botones;
	
	// Use this for initialization
	void Start () 
	{
		this.cantidadBotones = botones.Length;
		Debug.Log(cantidadBotones = botones.Length);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{

		//GUI.Label(new Rect(250,100,100,100), "Revienta las esferas!", estilo);

		for (int i = 0; i< this.cantidadBotones; i++)
		{
			if(GUI.Button(new Rect(botones[i].x,botones[i].y,botones[i].sizeX ,botones[i].sizeY ) , botones[i].title ))
			{
				Debug.Log("Cargar el nivel " + botones[i].title);
				Application.LoadLevel(botones[i].escena);
			}
		}


		//if(GUI.Button(new Rect(300,150,100,50) , "Inicio"))
		//{
		//	Debug.Log("Cargar el nivel " + nivelCarga);
		//	Application.LoadLevel(nivelCarga[0]);
		//}
		
		//if(GUI.Button(new Rect(300,220,100,50) , "Instrucciones"))
		//{
		//	Debug.Log("Cargar el nivel " + nivelCarga);
		//	Application.LoadLevel(nivelCarga[1]);
		//}	
		
	}
}
