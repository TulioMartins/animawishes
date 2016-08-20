using UnityEngine;
using System.Collections;

public class SelectionManager : MonoBehaviour {

	public GameObject[] characters;

	private GameObject selected = null;

	public void OnCharacterSelected(GameObject obj)
	{
		foreach (var character in characters) 
		{
			character.GetComponentInChildren<Character>().ClearParticles();
		}
	}


}
