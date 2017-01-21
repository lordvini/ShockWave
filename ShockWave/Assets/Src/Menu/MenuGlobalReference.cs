using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuGlobalReference : Singleton<MenuGlobalReference>
{
	public Image BGMenu;

	#region MainMenu
	public GameObject PanelMainMenu;
	public GameObject BtnVs;
	public GameObject BtnOp;
	public GameObject BtnC;
	public GameObject BtnX;
	#endregion

	#region TypesFX
	[System.NonSerialized]
	public string FXTypeFade 	= "fade", FXTypeMove = "move", FXTypeScale = "scale";
	#endregion
}
