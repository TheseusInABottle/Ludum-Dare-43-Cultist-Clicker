using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	public ClickManager clicker;

	public AudioSource upgradeSound;

	public Text upgradeInfo;

	public string itemName;

	public float upgradePrice;
	private float upgradeNewPrice;
	public float autoClicks;
	public float upgradeCount;
	public float bloodPerSecond;

	private float questionOrName;

	void Start()
	{
		questionOrName = upgradePrice / 1.5f;
		upgradeInfo.text = "???";
		gameObject.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update ()
	{
		if (clicker.bloodPoints >= questionOrName)
		{
			upgradeInfo.text = itemName + " | " + upgradePrice + " Pints" + "\n + " + autoClicks + " per second";
		}
	}

	public void AutoClickers()
	{
		if (clicker.bloodPoints >= upgradePrice)
		{
			upgradeSound.Play();
			clicker.bloodPoints = clicker.bloodPoints - upgradePrice;
			upgradeNewPrice = Mathf.Round(upgradePrice * 1.75f);
			upgradePrice = upgradeNewPrice;
			upgradeCount++;
			StartCoroutine(AutoClicking());
		}
	}

	IEnumerator AutoClicking()
	{
		while (upgradeCount > 0)
		{ 
			float clickAdd = bloodPerSecond;
			clicker.bloodPoints = clicker.bloodPoints + clickAdd;
			yield return new WaitForSeconds(1);
		}
		
	}
}
