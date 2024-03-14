using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RoleModule : BaseModule
{
	private static RoleModule roleModule;
	public static RoleModule Instance{
		get{
			if(roleModule == null)
			{
				roleModule = new RoleModule();
				roleModule.Init();
			}
			return roleModule;
		}
	}
	public PlayerData data;
	public override void Init()
	{
		data = new PlayerData();
		data.Init();

	}
	public void UpLevel()
	{
		data.SetData(data.LevelPlayer + 1);
		ListenerManager.Instance.TriggerEvent(TestEvent.EventType.MainEvt2);
	}

	public override void Destroy()
	{

	}
}