namespace ScheduleOne.ObjectScripts
{
	public class GrowLight : global::ScheduleOne.EntityFramework.ProceduralGridItem
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Misc.ToggleableLight Light;

		public global::ScheduleOne.Lighting.UsableLightSource usableLightSource;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EGrowLightAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EGrowLightAssembly_002DCSharp_002Edll_Excuted;

		public override void InitializeProceduralGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, int _rotation, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public void SetIsOn(bool isOn)
		{
		}

		protected override void Destroy()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
