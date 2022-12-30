using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using Verse;
using Verse.AI;

namespace Open_Hearted
{
	[StaticConstructorOnStartup]
	public static class HarmonyPatches
	{
		private static readonly Type patchType = typeof(HarmonyPatches);

		static HarmonyPatches()
		{
			Harmony harmony = new Harmony("com.openhearted");

			Harmony.DEBUG = true;

			FileLog.Log("Open Hearted");

			var assembly = Assembly.GetExecutingAssembly();

			harmony.PatchAll(assembly);
		}
	}

	[HarmonyPatch(typeof(MentalBreaker))]
	[HarmonyPatch("CurrentPossibleMoodBreaks", MethodType.Getter)]
	public static class CurrentPossibleMoodBreaks_OpenHearted
	{
		[HarmonyPrefix]
		public static bool CurrentPossibleMoodBreaks_Prefix(ref IEnumerable<MentalBreakDef> __result, MentalBreaker __instance)
		{
			//Need to make a delegate to get MentalBreaker.pawn because it's private.

			//If __instance.pawn has gene Open_Hearted set __result to ["GriefDeath"] or something like that and return false
			//Else return true
		}
	}
}
