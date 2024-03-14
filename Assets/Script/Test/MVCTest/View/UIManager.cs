using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
	GameObject canvas;
	private static UIManager uIManager;
	public static UIManager Instance{
		get{
			if(uIManager == null)
			{
				uIManager = new UIManager();
				uIManager.Init();
			}
			return uIManager;
		}
	}
	public void Init()
	{
		canvas = GameObject.Find("Canvas");
	}
}