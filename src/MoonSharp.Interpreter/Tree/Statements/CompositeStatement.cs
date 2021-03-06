﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Grammar;

namespace MoonSharp.Interpreter.Tree.Statements
{
	class CompositeStatement : Statement 
	{
		Statement[] m_Statements;

		public CompositeStatement(LuaParser.StatContext context, ScriptLoadingContext lcontext)
			: base(context, lcontext)
		{
			if (context.ChildCount > 0)
			{
				m_Statements = context.children
					.Select(t => NodeFactory.CreateStatement(t, lcontext))
					.Where(s => s != null)
					.ToArray();
			}
		}

		public CompositeStatement(LuaParser.BlockContext context, ScriptLoadingContext lcontext)
			: base(context, lcontext)
		{
			if (context.ChildCount > 0)
			{
				m_Statements = context.children
					.Select(t => NodeFactory.CreateStatement(t, lcontext))
					.Where(s => s != null)
					.ToArray();
			}
		}


		public override void Compile(Execution.VM.ByteCode bc)
		{
			if (m_Statements != null)
			{
				foreach (Statement s in m_Statements)
				{
					if (!(s is NullStatement))
					{
						bc.Emit_Debug(s.TreeNode.GetText());
						s.Compile(bc);
					}
				}
			}
		}
	}
}
