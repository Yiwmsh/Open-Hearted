using HarmonyLib;
using Verse;

namespace Open_Hearted
{
	[StaticConstructorOnStartup]
	public class Main
	{
		static Main()
		{
			var harmony = new Harmony("com.openhearted");
			harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
