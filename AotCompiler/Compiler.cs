using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mono.Cecil;
using static System.Console;

namespace AotCompiler {
	class Compiler {
		DefaultAssemblyResolver resolver;
		
		internal void Compile(string assembly) {
			resolver = new DefaultAssemblyResolver();
			resolver.AddSearchDirectory(Path.GetDirectoryName(assembly));
			var basm = AssemblyDefinition.ReadAssembly(assembly, new ReaderParameters {AssemblyResolver = resolver});
			var allasm = FindRefs(basm);
			foreach(var asm in allasm) {
				WriteLine(asm.FullName);
			}
		}
		
		IEnumerable<AssemblyDefinition> FindRefs(AssemblyDefinition asm) {
			return new[] { asm }.Concat(asm.MainModule.AssemblyReferences.Select(x => FindRefs(resolver.Resolve(x))).SelectMany(x => x));
		}
	}
}
