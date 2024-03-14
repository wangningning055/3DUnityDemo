using System.Collections.Generic;
using UnityEditor;
using XLua;
using System;

namespace Gen.Editor{
	public static class XLuaGenConfig
	{
		[LuaCallCSharp] public static List<Type> luacallcsharp = new List<Type>{

			typeof(Delegate_LuaTable_String),
			typeof(Delegate_Void_Float),
			typeof(Delegate_Void_Void)


		};


	}

}