using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace InfinityListSpace
{
	public enum ListType
	{
		Infinity = 0,
		NUms = 1
	}
	public class InfinityList
	{
		int columnNum;
		int itemNum;
		int viewNum;
		GameObject itemObj;
		ListType listType;
		ListPooL listPooL;
		public void Init(int num,int viewNum,  GameObject obj, int columnNum, ListType type)
		{
			this.columnNum = columnNum;
			itemNum = num;
			itemObj = obj;
			listType = type;
			this.viewNum = viewNum;
			listPooL = new ListPooL();
			listPooL.Init();
		}

		public GameObject getItem(GameObject item, int index)
		{
			GameObject cur = listPooL.GetItem(item);
			this.SetData(cur, index);
			return cur;
		}

		public void backItem(GameObject item)
		{
			listPooL.BackItem(item);
		}
		public void GetViewNum()
		{

		}
		public virtual void SetData(GameObject item, int dataIndex)
		{

		}
	
	}
}