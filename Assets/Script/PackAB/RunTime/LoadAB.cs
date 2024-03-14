// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LoadAB : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
// 		LoadImmdiatly("prefab", "Cube");
// 		StartCoroutine(LoadAsync("prefab", "Sphere"));
//     }
// 	void LoadImmdiatly(string abName, string ObjName)
// 	{
// 		AssetBundle ab = AssetBundle.LoadFromFile(Application.dataPath + "/" + "AssetBundle" + "/" + abName + ".assetBundle");

// 		AssetBundle abMain = AssetBundle.LoadFromFile(Application.dataPath + "/" + "AssetBundle" + "/" + "AssetBundle");

// 		AssetBundleManifest abM = abMain.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
// 		string[] dependices = abM.GetAllDependencies(abName + ".assetBundle");
// 		for(int i = 0; i < dependices.Length; i++)
// 		{
// 			AssetBundle.LoadFromFile(Application.dataPath + "/" + "AssetBundle" + "/" + dependices[i]);
// 		}
// 		GameObject cube = ab.LoadAsset<GameObject>(ObjName);
// 		Instantiate(cube);
// 	}

// 	IEnumerator LoadAsync(string abName, string ObjName)
// 	{
// 		AssetBundleCreateRequest ab = AssetBundle.LoadFromFileAsync(Application.dataPath + "/" + "AssetBundle" + "/" + abName + ".assetBundle");
// 		yield return ab;
// 		AssetBundleRequest abr = ab.assetBundle.LoadAssetAsync<GameObject>(ObjName);
// 		yield return abr;
// 		GameObject sphere = abr.asset as GameObject;
// 		Instantiate(sphere);

// 	}

// }
