using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour {

	public GameObject influenceBar;
	public Transform influenceMarker;
	public GameObject player;
	private List<GameObject> players = new List<GameObject> ();
	private int playerCount = 2;

	void Start () {
		for (int i=0; i < playerCount; i++) {
			players.Add (Instantiate(player));
		}
		Instantiate (influenceBar);
		Instantiate (influenceMarker);
	}

}
