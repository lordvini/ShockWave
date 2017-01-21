using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FXMyMenuComponent : Singleton<FXMyMenuComponent> 
{
	private float alpha = 0;


	public void FadeBGMenu()
	{
		StartCoroutine (DoFadeBGMenu (0.0001f, MenuGlobalReference.instance.BGMenu.GetComponent<Image>()));
	}

	public IEnumerator DoFadeBGMenu(float time, Image imageFade)
	{		 
		yield return new WaitForSeconds (time);

		if (imageFade.color.a <= 1) 
		{
			alpha += 0.02f;
			imageFade.color = new Color (255, 255, 255, alpha);
			StartCoroutine(DoFadeBGMenu(time, imageFade));
		} 
		else 
		{
			alpha = 0;
			iTween.MoveTo(MenuGlobalReference.instance.ImgLogo, iTween.Hash("y", 41.4f, "time", 0.6f, "easeType", "easeOutBack", "oncomplete", "ScaleButtons", "oncompletetarget",gameObject));
			StopCoroutine(DoFadeBGMenu(time, imageFade));
		}
	}

	public void ScaleButtons()
	{
		if (MenuGlobalReference.instance.BtnVs.transform.localScale.x < 1) 
		{
			iTween.ScaleTo(MenuGlobalReference.instance.BtnVs, iTween.Hash("x", 1, "y", 1, "z", 1, "time", 0.3f, "easeType", "easeOutBack", "oncomplete", "ScaleButtons", "oncompletetarget",gameObject));
		} 
		else if (MenuGlobalReference.instance.BtnC.transform.localScale.x < 1) 
		{
			iTween.ScaleTo(MenuGlobalReference.instance.BtnC, iTween.Hash("x", 1, "y", 1, "z", 1, "time", 0.3f, "easeType", "easeOutBack", "oncomplete", "ScaleButtons", "oncompletetarget",gameObject));
		} 
		else if (MenuGlobalReference.instance.BtnOp.transform.localScale.x < 1) 
		{
			iTween.ScaleTo(MenuGlobalReference.instance.BtnOp, iTween.Hash("x", 1, "y", 1, "z", 1, "time", 0.3f, "easeType", "easeOutBack", "oncomplete", "ScaleButtons", "oncompletetarget",gameObject));
		} 
		else if (MenuGlobalReference.instance.BtnX.transform.localScale.x < 1) 
		{
			iTween.ScaleTo(MenuGlobalReference.instance.BtnX, iTween.Hash("x", 1, "y", 1, "z", 1, "time", 0.3f, "easeType", "easeOutBack", "oncomplete", "DropPlayerInScreen", "oncompletetarget",gameObject));
		}
	}

	public void DropPlayerInScreen()
	{
		if (MenuGlobalReference.instance.ImgPlayer.transform.position.y >= -55) 
		{
			iTween.ShakePosition(Camera.main.gameObject, iTween.Hash("x", 1.9f, "time", 0.1f));
			iTween.MoveTo (MenuGlobalReference.instance.ImgPlayer, iTween.Hash ("y", -55.0f, "time", 0.6f, "easeType", "easeOutBack", "oncomplete", "ScaleButtons", "oncompletetarget", gameObject));			
		} 
		else 
		{

		}
	}



}
