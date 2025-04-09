using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Lighting;
using ScheduleOne.Misc;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class GrowLight : ProceduralGridItem
	{
		[Header("References")]
		public ToggleableLight Light;

		public UsableLightSource usableLightSource;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EGrowLightAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EGrowLightAssembly_002DCSharp_002Edll_Excuted;

		public override void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		public void SetIsOn(bool isOn)
		{
		}

		public override void DestroyItem(bool callOnServer = true)
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
