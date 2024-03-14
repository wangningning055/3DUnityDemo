
using System.Collections.Generic;
using UnityEngine;

public class ListPooL
{
	Queue<GameObject> gameObjects;
	int poolSize = 30;
	
	public void Init()
	{
		gameObjects = new Queue<GameObject>();
	}
	public GameObject GetItem(GameObject item)
	{
		if(gameObjects.Count > 0)
		{
			GameObject obj = gameObjects.Dequeue();
			obj.SetActive(true);
			return obj;
		}
		else
		{
			GameObject obj = GameObject.Instantiate(item);
			obj.SetActive(true);
			return obj;
		}
	}


	public void BackItem(GameObject item)
	{
		if(gameObjects.Count < poolSize)
		{
			item.SetActive(false);
			gameObjects.Enqueue(item);
		}
	}
}