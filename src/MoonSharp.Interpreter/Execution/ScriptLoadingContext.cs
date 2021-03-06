﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution
{
	class ScriptLoadingContext
	{
		public Script Script { get; private set; }
		public BuildTimeScope Scope { get; set; }
		public SourceCode Source { get; set; }
		public bool Anonymous { get; set; }
		public bool IsDynamicExpression { get; set; }

		public ScriptLoadingContext(Script s)
		{
			Script = s;
		}
	}
}
