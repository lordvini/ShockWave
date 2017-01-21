using UnityEngine;
using System.Collections;

public class GlobalReference : Singleton<GlobalReference>
{
	[SerializeField]
	public GameObject davson;

	public class Tags
	{
		public const string Player = "Player";
	}

	public class Inputs
	{
		public const string Basic_Attack = "Basic Attack";
	}
}
