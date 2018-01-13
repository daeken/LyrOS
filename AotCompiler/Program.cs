using static System.Console;

namespace AotCompiler {
	internal class Program {
		public static void Main(string[] args) {
			var compiler = new Compiler();
			compiler.Compile(args[0]);
		}
	}
}
