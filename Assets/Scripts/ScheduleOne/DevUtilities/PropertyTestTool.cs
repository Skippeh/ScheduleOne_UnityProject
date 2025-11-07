namespace ScheduleOne.DevUtilities
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Property.Property))]
	public class PropertyTestTool : global::FishNet.Object.NetworkBehaviour
	{
		public global::ScheduleOne.Property.Property Property;

		public global::UnityEngine.TextAsset PropertyDataToLoad;

		private bool NetworkInitialize___EarlyScheduleOne_002EDevUtilities_002EPropertyTestToolAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDevUtilities_002EPropertyTestToolAssembly_002DCSharp_002Edll_Excuted;

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public virtual void Awake()
		{
		}
	}
}
