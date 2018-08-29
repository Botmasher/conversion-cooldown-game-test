using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour {

	//public GameObject influenceBar;
	//public Transform influenceMarker;
	public GameObject player;
	private List<GameObject> players = new List<GameObject> ();
	private int playerCount = 2;

	void Start () {
		for (int i=0; i < playerCount; i++) {
			players.Add (Instantiate(player));
		}
		GameObject influenceBar = GameObject.CreatePrimitive (PrimitiveType.Cube);
		influenceBar.transform.localScale = new Vector3 (3.5f, 0.2f, 0.1f);
		influenceBar.transform.Translate (Vector3.up * 2f);
		GameObject influenceMarker = GameObject.CreatePrimitive (PrimitiveType.Cube);
		influenceMarker.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		influenceMarker.transform.Translate (Vector3.up * 1.78f);
//		Instantiate (influenceBar);
//		Instantiate (influenceMarker);
	}

}
