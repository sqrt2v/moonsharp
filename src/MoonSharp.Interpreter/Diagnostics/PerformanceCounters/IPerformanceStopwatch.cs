﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters
{
	public interface IPerformanceStopwatch
	{
		IDisposable Start();
		PerformanceResult GetResult();
	}
}
