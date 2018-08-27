using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	int influenceFactor = 0;

	public string unitName;
	public KeyCode unitKeyCode;
	void activateUnit ();

	public string abilityName;
	public KeyCode abilityKeyCode;
	void activateAbility ();

	public string specialName;
	public KeyCode specialKeyCode;
	void activateSpecial();

	Dictionary<KeyCode, string> actionKeyCodes = new Dictionary<KeyCode, string> ();
	Dictionary<string, System.Action> actionActivations = new Dictionary<string, System.Action> ();

	void Start() {
		actionKeyCodes.Add (abilityKeyCode, abilityName);
		actionKeyCodes.Add (unitKeyCode, unitName);
		actionKeyCodes.Add (specialKeyCode, specialName);
		actionActivations.Add (unitName, activateUnit);
		actionActivations.Add (abilityName, activateAbility);
		actionActivations.Add (specialName, activateSpecial);
	}

	void Update () {
		foreach (KeyValuePair<KeyCode, string> entry in actionKeyCodes) {
			if (Input.GetKeyDown (entry.Key)) {
				actionActivations [entry.Value] ();
			}
		}
	}

}
