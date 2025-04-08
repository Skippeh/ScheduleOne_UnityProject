namespace ScheduleOne.Property.Utilities.Power
{
	public class PowerLine : global::ScheduleOne.ConstructableScripts.Constructable
	{
		public static int powerLine_MinSegments;

		public static int powerLine_MaxSegments;

		public static float maxLineLength;

		public static float updateThreshold;

		public global::ScheduleOne.Property.Utilities.Power.PowerNode nodeA;

		public global::ScheduleOne.Property.Utilities.Power.PowerNode nodeB;

		public float LengthFactor;

		protected global::System.Collections.Generic.List<global::UnityEngine.Transform> segments;

		private global::UnityEngine.Vector3 nodeA_LastUpdatePos;

		private global::UnityEngine.Vector3 nodeB_LastUpdatePos;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EUtilities_002EPower_002EPowerLineAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EUtilities_002EPower_002EPowerLineAssembly_002DCSharp_002Edll_Excuted;

		public void InitializePowerLine(global::ScheduleOne.Property.Utilities.Power.PowerNode a, global::ScheduleOne.Property.Utilities.Power.PowerNode b)
		{
		}

		public override void DestroyConstructable(bool callOnServer = true)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void RefreshVisuals()
		{
		}

		private void RefreshBoundingBox()
		{
		}

		public global::ScheduleOne.Property.Utilities.Power.PowerNode GetOtherNode(global::ScheduleOne.Property.Utilities.Power.PowerNode firstNode)
		{
			return null;
		}

		public void SetVisible(bool v)
		{
		}

		public override global::UnityEngine.Vector3 GetCosmeticCenter()
		{
			return default(global::UnityEngine.Vector3);
		}

		public static bool CanNodesBeConnected(global::ScheduleOne.Property.Utilities.Power.PowerNode nodeA, global::ScheduleOne.Property.Utilities.Power.PowerNode nodeB)
		{
			return false;
		}

		public static int GetSegmentCount(global::UnityEngine.Vector3 startPoint, global::UnityEngine.Vector3 endPoint)
		{
			return 0;
		}

		public static void DrawPowerLine(global::UnityEngine.Vector3 startPoint, global::UnityEngine.Vector3 endPoint, global::System.Collections.Generic.List<global::UnityEngine.Transform> segments, float lengthFactor)
		{
		}

		private static void PositionSegments(global::System.Collections.Generic.List<global::UnityEngine.Vector3> points, global::System.Collections.Generic.List<global::UnityEngine.Transform> segments)
		{
		}

		private static global::System.Collections.Generic.List<global::UnityEngine.Vector3> GetCatenaryPoints(global::UnityEngine.Vector3 startPoint, global::UnityEngine.Vector3 endPoint, int pointCount, float l)
		{
			return null;
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
