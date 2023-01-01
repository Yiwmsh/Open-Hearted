using RimWorld;
using Verse;

namespace Open_Hearted
{
	[DefOf]
	public static class InternalDefOfs
	{
		static InternalDefOfs()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(InternalDefOfs));
		}

		public static GeneDef Open_Hearted;
		public static MentalBreakDef Grief_Stricken;
		public static MentalStateDef Grief_Death;
	}
}
