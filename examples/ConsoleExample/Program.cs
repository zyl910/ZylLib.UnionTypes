using System;
using System.Collections.Generic;
using System.Text;
using ZylLib.UnionTypes;

namespace ZylLib.UnionTypes.ConsoleExample {
	class Program {
		static void Main(string[] args) {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("ZylLib.UnionTypes.ConsoleExample");
			sb.AppendLine();
			UnionTypesExample.Output(sb);
			// show.
			Console.WriteLine(sb.ToString());
		}

	}
}
