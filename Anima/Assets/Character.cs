using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
	public GameObject particles;

	private bool overCharacter = false;

	public Material overMaterial;
	public Material selectedMaterial;
	private bool selected = false;

	// Use this for initialization
	void Update () 
	{
		if (Input.GetMouseButtonDown (0) && overCharacter) 
		{
			this.transform.parent.GetComponent<SelectionManager>().OnCharacterSelected(gameObject);
			selected = true;
			GetComponentInChildren<ParticleSystem> ().emissionRate = 25;
			particles.GetComponent<Renderer> ().material = selectedMaterial;
		}
	}
	
	void OnMouseEnter()
	{
		GetComponentInChildren<ParticleSystem> ().emissionRate = 10;
		overCharacter = true;
	}

	void OnMouseExit()
	{
		overCharacter = false;
		if (selected)
			return;
		GetComponentInChildren<ParticleSystem> ().emissionRate = 0;
	}

	public void ClearParticles()
	{
		GetComponentInChildren<ParticleSystem> ().emissionRate = 0;
		particles.GetComponent<Renderer> ().material = overMaterial;
		selected = false;
	}

}
