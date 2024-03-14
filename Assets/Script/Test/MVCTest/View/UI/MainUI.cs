using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : BaseUI
{
	public Text PlayerName;
	public Text Level;
	public Button Change;
	public Button UpLevel;
	public Button SaveData;
	public MainUICtr mainUICtr;
	public override void Init<T>(T cla)
	{
		mainUICtr = new MainUICtr(this);
	}
	public override void UpdatePage<T>(T cla)
	{

	}
	void Awake()
	{
		mainUICtr = new MainUICtr(this);
	}
}