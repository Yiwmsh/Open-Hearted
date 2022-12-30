﻿using HarmonyLib;
using System.Reflection;
using Verse;

namespace Open_Hearted
{
	[StaticConstructorOnStartup]
	public class Main
	{
		static Main()
		{
			var harmony = new Harmony("rimworld.snootydoots.openhearted");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}