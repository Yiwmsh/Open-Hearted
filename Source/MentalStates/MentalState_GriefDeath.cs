using Verse.AI;
namespace Open_Hearted
{
	public class MentalState_GriefDeath : MentalState
	{

		public override void MentalStateTick()
		{
			base.MentalStateTick();
			base.pawn.Kill(null, null);
		}
	}
}
