using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
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
		public static bool CurrentPossibleMoodBreaks_Prefix(ref IEnumerable<MentalBreakDef> __result, MentalBreaker __instance, Pawn ___pawn)
		{
			if (___pawn.genes.HasGene(InternalDefOfs.Open_Hearted))
			{
				__result = new List<MentalBreakDef>() { InternalDefOfs.Grief_Stricken }.AsEnumerable();
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
