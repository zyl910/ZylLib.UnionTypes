# ZylLib.UnionTypes
Union types in C# (C#的联合体类型)

## Instruction

Struct (结构体) :

* `UnionShort`: Short union type, size is 2 byte (短整数联合体, 大小为2字节). Like `short[1]` .
* `UnionInt`: Int union type, size is 4 byte (整数联合体, 大小为4字节). Like `short[2]`, `int[1]`, `float[1]` .
* `UnionLong`: Long union type, size is 8 byte (长整数联合体, 大小为8字节). Like `short[4]`, `int[2]`, `long[1]`, `float[2]`, `double[1]` .

Interfaces (接口) :

* `IUnionShort`: Short union type interface (短整数联合体接口). Has LoadBytes/LoadBytesAt/SaveBytes/SaveBytesAt/ToByteArray/ToInt16Array methods.
* `IUnionInt`: Int union type interface (整数联合体接口). Inherited the IUnionShort interface. Has ToInt32Array/ToSingleArray methods.
* `IUnionLong`: Long union type interface (长整数联合体接口). Inherited the IUnionInt interface. Has ToInt64Array/ToInt64Array methods.

Features (特性) :

* Support VS2005(VS8.0, C#2.0) ~ VS2017(VS15.0, C#7.0) (支持VS2005至VS2017).
* CLS Compliant (CLR兼容).
* AllowPartiallyTrustedCallers. Allows an assembly to be called by partially trusted code (允许由部分信任的代码调用程序集).
* Support Xml Serialization (支持Xml序列化).
* Support WCF's DataContract Serialization (支持WCF的数据契约序列化). Need .Net 3.0+ (需要 .NET3.0 或更高).
* Support Binary Serialization (支持二进制序列化). Only .NET Framework, because only it supports SerializableAttribute (仅.NET Framework 时, 因为只有它支持 SerializableAttribute ).
* Generate .chm documentation by Sandcastle (Sandcastle生成的CHM文档).

Target frameworks (目标框架):

* `net20`: .NET Framework 2.0 . Support VS2005(VS8.0)+ .
* `net40`: .NET Framework 4.0 Client Profile. Support VS2010(VS10.0)+ .
* `portable40`: Portable Class Library Profile2 (可移植库配置2), portable-net40+win8+sl4+wp7 . Support VS2010(VS10.0)+ .
* `netstandard1.0`: .NET Standard 1.0 . Support VS2015(VS14.0)+ .
