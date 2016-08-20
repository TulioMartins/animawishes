using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoginButton : MonoBehaviour 
{
	public GameObject login;
	public GameObject password;

	private Text loginText;
	private Text passwordText;

	void Start () 
	{
		Debug.Log (gameObject);
		this.loginText = login.GetComponent<Text> ();
		this.passwordText = password.GetComponent<Text> ();
		var button = GetComponent<Button> ();
		button.onClick.AddListener (OnClick);
	}

	void OnClick()
	{
		Debug.Log ("Login with " + loginText.text + " and " + passwordText.text);
		Application.LoadLevel (1);
	}

}
