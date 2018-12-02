using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeManager : MonoBehaviour {

	public ClickManager knifeMan;

	public AudioSource knifeBuy;

	public Text knifeInfo;
	public string itemName;

	public float knifePrice;
	public float knifeNewPrice;
	public float knifeClicks;

	public float clickMultiplyer;

	// Update is called once per frame
	void Update ()
	{
		knifeInfo.text = itemName + " | " + knifePrice + " Pints" + "\n + " + knifeClicks + " per click";
	}

	public void KnifeBought()
	{
		if (knifeMan.bloodPoints >= knifePrice)
		{
			knifeMan.bloodPoints = knifeMan.bloodPoints - knifePrice;
			knifeMan.clickValue = knifeMan.clickValue + clickMultiplyer;
			knifeNewPrice = Mathf.Round(knifePrice * 1.5f);
			knifePrice = knifeNewPrice;
			knifeBuy.Play();
		}
	}
}
