# ZylLib.UnionTypes
Union types in C# (C#的联合体类型)

## Instruction

Struct (结构体) :

* `UnionShort`: Short union type, size is 2 byte (短整数联合体, 大小为2字节). Like `short[1]` .
* `UnionInt`: Int union type, size is 4 byte (整数联合体, 大小为4字节). Like `short[2]`, `int[1]`, `float[1]` .
* `UnionLong`: Long union type, size is 8 byte (长整数联合体, 大小为8字节). Like `short[4]`, `int[2]`, `long[1]`, `float[2]`, `double[1]` .

Interfaces (接口) :

* `IUnionShort`: Short union type interface (短整数联合体接口).
* `IUnionInt`: Int union type interface (整数联合体接口).
* `IUnionLong`: Long union type interface (长整数联合体接口).

Features (特性) :

* Support VS2005(VS8.0, C#2.0) ~ VS2017(VS15.0, C#7.0) (支持VS2005至VS2017).
* CLS Compliant (CLR兼容).
* AllowPartiallyTrustedCallers. Allows an assembly to be called by partially trusted code (允许由部分信任的代码调用程序集).
* Generate .chm documentation by Sandcastle (Sandcastle生成的CHM文档).

Target frameworks (目标框架):

net20: .NET Framework 2.0 . Support VS2005(VS8.0)+ .
pcl40: Portable Class Library Profile1 (可移植库配置1), portable-net40+win8+sl4+wp7+xbox . Support VS2010(VS10.0)+ .
netstd10: .NET Standard 1.0 . Support VS2015(VS14.0)+ .
