using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;
public class CoroutineTest2 : MonoBehaviour
{
	bool isOk = true;
	int count = 0;
	void Start()
	{
		StartCoroutine(Asasdd());
	}

	public IEnumerator Asasdd()
	{
		Debug.Log("开启");
		yield return null;
		Debug.Log("执行");
		yield return new WaitWhile(() => {
			return isOk;
		});
		Debug.Log("执行2" + isOk.ToString());
	}
	void Update()
	{
		if(count < 10)
			Debug.Log("Main Update");
		else
			isOk =false;
		count++;
	}
}