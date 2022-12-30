using Verse.AI;
namespace Open_Hearted
{
	public class MentalState_GriefDeath : MentalState
	{
		public override void PreStart()
		{
			base.PreStart();
			base.pawn.health.SetDead();
		}
	}
}
