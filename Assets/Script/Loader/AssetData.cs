using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AssetData
{
	public SourceType sourceType;
	public string sourceName;
	public string path;
}
[Serializable]
public class AssetDataList
{
	public static string jsonPath = Application.dataPath + "/AssetData/data";
	public List<AssetData> datas;
}
