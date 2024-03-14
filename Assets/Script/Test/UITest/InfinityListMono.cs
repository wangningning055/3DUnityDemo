using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;
using InfinityListSpace;
using System.Security.Cryptography;
using UnityEngine.UI;
using System.Runtime.ConstrainedExecution;

public class InfinityListMono:MonoBehaviour
{
	int dataNum = 20;
	int viewHeight = 500;
	int columnNum;
	float height;
	float weidgth;

	int pading = 30;

	public GameObject item;
	float itemHeight;
	InfinityList infinityList;
	float upY = 0;
	float downY = 0;
	float contentHeight = 0;
	int upIndex, downIndex;
	RectTransform conteneRect;
	float singleRat = 0; 

	float curRate = 0;
	void Start()
	{
		infinityList = new PicList();
		Transform view = gameObject.transform.Find("view");
		Transform content = view.Find("content");

		RectTransform viewRect = view.GetComponent<RectTransform>();
		conteneRect = content.GetComponent<RectTransform>();


		itemHeight = item.GetComponent<RectTransform>().rect.height;

		contentHeight = itemHeight * dataNum + pading * (dataNum - 1);
		contentHeight = contentHeight > viewHeight? contentHeight: viewHeight;
		viewRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, viewHeight);
		conteneRect.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 100, contentHeight);

		int viewNum = (int)viewHeight / ((int)itemHeight + (int)pading) + 1;
		infinityList.Init(dataNum, viewNum, item, 1, ListType.NUms);

		int targetNum = viewNum * 2 > dataNum? dataNum:viewNum * 2;

		upY = contentHeight / 2;
		downY = contentHeight / 2 - viewHeight;
		print($"总数： {dataNum}， 显示数： {targetNum}");
		upIndex = 0;
		downIndex = targetNum + 1;
		singleRat = (itemHeight + pading) / contentHeight;
		for(int i = 0; i < dataNum; i++)
		{
			GameObject child = infinityList.getItem(item, i);
			child.SetActive(false);
			child.transform.SetParent(content);
			float y = contentHeight / 2 - itemHeight / 2 -  (i * (itemHeight + pading));
			child.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, y);
			// if(i == 0)
			// {
			// 	child.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, downY);


			// }
			//

			//
			//

			//
			//
	
		}
		GetComponent<ScrollRect>().onValueChanged.AddListener(UpdateList);
	}



	void UpdateList(Vector2 vec)
	{
		float ra = (contentHeight / 2 - conteneRect.anchoredPosition.y) / contentHeight;
		print($"{vec.y}   {ra},   {singleRat}");
		if(Math.Abs(vec.y - curRate) >= singleRat)
		{
			if((vec.y - curRate) > 0)
				upIndex--;
			else
				upIndex++;
			print($"更新一下   {upIndex}");
			curRate = vec.y;
		}		
	}

	void Update()
	{

	}
}