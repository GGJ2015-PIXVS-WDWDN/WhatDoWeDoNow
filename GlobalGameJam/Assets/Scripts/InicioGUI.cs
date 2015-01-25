using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class InicioGUI : MonoBehaviour 
{

	public Button[] botones;
	private int cantidadBotones;

	public GUIStyle estiloGUI;

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

		for (int i = 0; i< this.cantidadBotones; i++)
		{
			if(GUI.Button(new Rect(botones[i].x,botones[i].y,botones[i].sizeX ,botones[i].sizeY ) , botones[i].title, estiloGUI))
			{
				Debug.Log("Cargar el nivel " + botones[i].title);
				Application.LoadLevel(botones[i].escena);
			}
		}


	}
}
