using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static float score = 0.0f;
	public float leak = 0.01f; 			// rate of score loss over time
	public GameObject player;
	private List<GameObject> players = new List<GameObject> ();
	private int playerCount = 2;
	private float influenceMarkerRange = 0f;
	private GameObject influenceBar;
	private GameObject influenceMarker;

	void Start () {
		for (int i=0; i < playerCount; i++) {
			players.Add (Instantiate(player));
		}
		influenceBar = GameObject.CreatePrimitive (PrimitiveType.Cube);
		influenceBar.transform.localScale = new Vector3 (3.5f, 0.2f, 0.1f);
		influenceBar.transform.Translate (Vector3.up * 2f);
		influenceMarker = GameObject.CreatePrimitive (PrimitiveType.Cube);
		influenceMarker.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		influenceMarker.transform.Translate (Vector3.up * 1.78f);
		influenceMarkerRange = influenceBar.transform.localScale.x;
	}

	void Update () {
		score = score - (score * leak * Time.deltaTime);
		influenceMarker.transform.Translate(influenceMarkerRange * score, 0f, 0f);
		// keep marker in bounds
		if (influenceMarker.transform.position.x > influenceMarkerRange || influenceMarker.transform.position.x < -influenceMarkerRange) {
			influenceMarker.transform.position = Vector3.Lerp (influenceMarker.transform.position, new Vector3 (0f, influenceMarker.transform.position.y, influenceMarker.transform.position.z), Time.deltaTime);
		}
	}
}
