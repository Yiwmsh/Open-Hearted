﻿using HarmonyLib;
using System.Reflection;
using Verse;

namespace Open_Hearted
{
	[StaticConstructorOnStartup]
	public static class Main
	{
		static Main()
		{
			var harmony = new Harmony("com.openhearted");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
