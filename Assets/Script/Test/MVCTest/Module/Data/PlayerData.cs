using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerData : BaseData
{
	public string PlayerName;
	public int LevelPlayer;
		
	
	public override void Init()
	{
		PlayerName = GetPreferData("PlayerName", "玩家1");
		LevelPlayer = GetPreferData("LevelPlayer", 5);
	}
	public override void SaveData()
	{
		SetPreferData("PlayerName", PlayerName);
		SetPreferData("LevelPlayer", LevelPlayer);
	}
	public override void SetData(int val)
	{
		LevelPlayer = val;
	}
	public override BaseData GetData()
	{
		return this;
	}
}