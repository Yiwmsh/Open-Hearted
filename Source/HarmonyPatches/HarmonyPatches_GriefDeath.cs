using HarmonyLib;
using Verse;
using Verse.AI;

namespace Open_Hearted
{
	[HarmonyPatch(typeof(MentalBreakWorker), "BreakCanOccur")]
	public static class Open_Hearted_MentalBreakWorker_BreakCanOccur_Patch
	{
		[HarmonyPostfix]
		static void DisableAllNonGriefOtherMentalBreaks(ref bool __result, Pawn pawn, MentalBreakWorker __instance)
		{
			if (pawn.genes?.HasGene(InternalDefOfs.Open_Hearted) == true)
			{
				if (__instance.def.defName != "Grief_Death")
				{
					__result = false;
				}
			}
		}
	}
}
