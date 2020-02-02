using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairable : Model
{
	//Se asigna el objeto desde la escena o su prefab.
	[SerializeField]
	private Model[] fragments;
	[SerializeField]
	private Space[] spaces;

	public void Break()
	{
		//Spawnea al azar los pedazos del objeto.
		//Les agrega un empuje pequeño en direcciones random.
		//Saca particulas
		//Destruye el objeto.
	}
}
