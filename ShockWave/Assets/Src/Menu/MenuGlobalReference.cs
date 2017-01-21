using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuGlobalReference : Singleton<MenuGlobalReference>
{
	public GameObject BGMenu;

	#region MainMenu
	public GameObject PanelMainMenu;
	public GameObject BtnVs;
	public GameObject BtnOp;
	public GameObject BtnC;
	public GameObject BtnX;
	public GameObject ImgLogo;
	public GameObject ImgPlayer;
	#endregion

	#region TypesFX
	[System.NonSerialized]
	public string FXTypeFade 	= "fade", FXTypeMove = "move", FXTypeScale = "scale";
	#endregion
}
