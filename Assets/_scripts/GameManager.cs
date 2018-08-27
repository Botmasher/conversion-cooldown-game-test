using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static float score = 0.0f;
	public float leak = 0.01f; 			// rate of score loss over time

	void Update () {
		score = score - (score * leak * Time.deltaTime);
	}
}
