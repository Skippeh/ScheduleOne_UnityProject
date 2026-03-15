namespace ScheduleOne.Experimental
{
	[global::System.Serializable]
	public class SkateboardSettings
	{
		public float TurnForce;

		public float TurnChangeRate;

		public float TurnReturnToRestRate;

		public float TurnSpeedBoost;

		public global::UnityEngine.AnimationCurve TurnForceMap;

		public float Gravity;

		public float BrakeForce;

		public float ReverseTopSpeed_Kmh;

		public float RotationClampForce;

		public bool FrictionEnabled;

		public global::UnityEngine.AnimationCurve LongitudinalFrictionCurve;

		public float LongitudinalFrictionMultiplier;

		public float LateralFrictionForceMultiplier;

		public float JumpForce;

		public float JumpDuration_Min;

		public float JumpDuration_Max;

		public global::UnityEngine.AnimationCurve FrontAxleJumpCurve;

		public global::UnityEngine.AnimationCurve RearAxleJumpCurve;

		public global::UnityEngine.AnimationCurve JumpForwardForceCurve;

		public float JumpForwardBoost;

		public float HoverForce;

		public float HoverRayLength;

		public float HoverHeight;

		public float Hover_P;

		public float Hover_I;

		public float Hover_D;

		[global::UnityEngine.Tooltip("Top speed in m/s")]
		public float TopSpeed_Kmh;

		public float PushForceMultiplier;

		public global::UnityEngine.AnimationCurve PushForceMultiplierMap;

		public float PushForceDuration;

		public float PushDelay;

		public global::UnityEngine.AnimationCurve PushForceCurve;

		public bool AirMovementEnabled;

		public float AirMovementForce;

		public float AirMovementJumpReductionDuration;

		public global::UnityEngine.AnimationCurve AirMovementJumpReductionCurve;

		public float TopSpeed_Ms => 0f;

		public global::ScheduleOne.Experimental.SkateboardSettings Clone()
		{
			return null;
		}

		public global::ScheduleOne.Experimental.SkateboardSettings Blend(global::ScheduleOne.Experimental.SkateboardSettings other, float blendFactor)
		{
			return null;
		}
	}
}
