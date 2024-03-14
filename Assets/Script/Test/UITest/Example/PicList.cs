using System.Collections.Generic;
using InfinityListSpace;
using UnityEngine;
using UnityEngine.UI;

public class PicList:InfinityList
{
	List<int> datas;
	public override void SetData(GameObject item, int dataIndex)
	{
		if(datas == null)
		{
			datas = new List<int>();
			for(int i = 0 ; i < 20; i++)
			{
				datas.Add(i);
			}
		}
		Transform text = item.transform.Find("Text");
		text.GetComponent<Text>().text = datas[dataIndex].ToString();
	}

	
}