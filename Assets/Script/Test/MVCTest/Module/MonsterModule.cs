using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MonsterModule : BaseModule
{
	MonsterData data;
	public override void Init()
	{
		data = new MonsterData();
		data.Init();
	}

	public override void Destroy()
	{

	}
}