using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BaseData
{
	public virtual void Init()
	{

	}
	public virtual void SaveData()
	{

	}
	public virtual void SetData(int val)
	{
	}
	public virtual BaseData GetData()
	{
		return this;
	}
	public static string GetPreferData(string key, string baseData)
	{
		if(PlayerPrefs.GetString(key) == "")
		{
			PlayerPrefs.SetString(key, baseData);
			return baseData;
		}
		return PlayerPrefs.GetString(key);
	}
	public static void SetPreferData(string key, string baseData)
	{
		PlayerPrefs.SetString(key, baseData);
	}
	public static int GetPreferData(string key, int baseData)
	{
		return PlayerPrefs.GetInt(key);
	}
	public static void SetPreferData(string key, int baseData)
	{
		PlayerPrefs.SetInt(key, baseData);
	}
}