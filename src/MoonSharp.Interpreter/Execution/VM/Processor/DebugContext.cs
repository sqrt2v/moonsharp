﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	sealed partial class Processor
	{
		private class DebugContext
		{
			public IDebugger DebuggerAttached = null;
			public DebuggerAction.ActionType DebuggerCurrentAction = DebuggerAction.ActionType.None;
			public int DebuggerCurrentActionTarget = -1;
			public SourceRef LastHlRef = null;
			public int ExStackDepthAtStep = -1;
			public List<SourceRef> BreakPoints = new List<SourceRef>();
		}
	}
}
