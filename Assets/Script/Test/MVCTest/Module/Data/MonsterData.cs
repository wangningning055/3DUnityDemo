using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MonsterData : BaseData
{
	string MonsterName;
	int Level;
	
	public override void Init()
	{
		MonsterName = GetPreferData("MonsterName", "啊实打实的");
		Level = GetPreferData("Level", 5);
	}
	public override void SaveData()
	{
		SetPreferData("MonsterName", MonsterName);
		SetPreferData("Level", Level);
	}

	public override BaseData GetData()
	{
		return this;
	}
}