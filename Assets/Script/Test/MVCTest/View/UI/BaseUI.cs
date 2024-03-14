using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
	public virtual void Init<T>(T cla) where T : BaseModule
	{

	}
	public virtual void UpdatePage<T>(T cla) where T : BaseModule 
	{

	}
}