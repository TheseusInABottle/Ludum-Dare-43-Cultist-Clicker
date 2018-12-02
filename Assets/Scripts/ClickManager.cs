using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour {

	public AudioSource squishSound;

	public Text resources;
	public Text bloodPerClick;

	public float bloodPoints;
	public float clickValue;

	// Use this for initialization
	void Start ()
	{
		bloodPoints = 0;
		clickValue = 1;
		gameObject.GetComponent<Text>();
		resources.text = bloodPoints + " Sacraficed";
		bloodPerClick.text = clickValue + "Sacraficed";
		gameObject.GetComponent<AudioSource>();
	}

	private void Update()
	{
		resources.text = bloodPoints + " Sacraficed!";
		bloodPerClick.text = clickValue + " Sacraficed per click!";
	}

	public void OnButtonClick()
	{
		bloodPoints = Mathf.Round (bloodPoints + clickValue);
		squishSound.Play();
	}


}
