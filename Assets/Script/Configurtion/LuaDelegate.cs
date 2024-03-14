using XLua;

[CSharpCallLua]
public delegate void Delegate_Void_Void();

[CSharpCallLua]
public delegate LuaTable Delegate_LuaTable_String(string module);

[CSharpCallLua]
public delegate void Delegate_Void_Float(float deltTime);