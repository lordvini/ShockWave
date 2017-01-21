using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyMenuManager : MonoBehaviour 
{
	void Start()
	{
		StartObjects ();
		Debug.Log (MenuGlobalReference.instance.ImgPlayer.transform.position);
		FXMyMenuComponent.instance.FadeBGMenu ();
	}

	private void StartObjects()
	{
		MenuGlobalReference.instance.BGMenu.GetComponent<Image> ().color = new Color (255, 255, 255, 0);
		MenuGlobalReference.instance.ImgLogo.transform.position = new Vector3 (0.0f, 75.8f, 90.0f);
		MenuGlobalReference.instance.BtnVs.transform.localScale = new Vector3 (0, 0, 0);
		MenuGlobalReference.instance.BtnOp.transform.localScale = new Vector3 (0, 0, 0);
		MenuGlobalReference.instance.BtnC.transform.localScale = new Vector3 (0, 0, 0);
		MenuGlobalReference.instance.BtnX.transform.localScale = new Vector3 (0, 0, 0);
		MenuGlobalReference.instance.ImgPlayer.transform.position = new Vector3 (60.0f, 100, 90.0f);
	}


	/***
	 * 
	 * Logo = (0.0 41.4, 90.0)
	 * 
	 * Player = (60.0f, -55.0f, 90.0f)
	 * 
	 * */
}