namespace ScheduleOne.AvatarFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "Avatar Settings", menuName = "ScriptableObjects/Avatar Settings", order = 1)]
	public class AvatarSettings : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public struct LayerSetting
		{
			public string layerPath;

			public global::UnityEngine.Color layerTint;
		}

		[global::System.Serializable]
		public class AccessorySetting
		{
			public string path;

			public global::UnityEngine.Color color;
		}

		public global::UnityEngine.Color SkinColor;

		public float Height;

		public float Gender;

		public float Weight;

		public string HairPath;

		public global::UnityEngine.Color HairColor;

		public float EyebrowScale;

		public float EyebrowThickness;

		public float EyebrowRestingHeight;

		public float EyebrowRestingAngle;

		public global::UnityEngine.Color LeftEyeLidColor;

		public global::UnityEngine.Color RightEyeLidColor;

		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration LeftEyeRestingState;

		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration RightEyeRestingState;

		public string EyeballMaterialIdentifier;

		public global::UnityEngine.Color EyeBallTint;

		public float PupilDilation;

		public global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.AvatarSettings.LayerSetting> FaceLayerSettings;

		public global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.AvatarSettings.LayerSetting> BodyLayerSettings;

		public global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.AvatarSettings.AccessorySetting> AccessorySettings;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public bool UseCombinedLayer;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.AvatarFramework.AvatarLayer CombinedLayer;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::UnityEngine.Texture2D ImpostorTexture;

		public float UpperEyelidRestingPosition => 0f;

		public float LowerEyelidRestingPosition => 0f;

		public string FaceLayer1Path => null;

		public global::UnityEngine.Color FaceLayer1Color => default(global::UnityEngine.Color);

		public string FaceLayer2Path => null;

		public global::UnityEngine.Color FaceLayer2Color => default(global::UnityEngine.Color);

		public string FaceLayer3Path => null;

		public global::UnityEngine.Color FaceLayer3Color => default(global::UnityEngine.Color);

		public string FaceLayer4Path => null;

		public global::UnityEngine.Color FaceLayer4Color => default(global::UnityEngine.Color);

		public string FaceLayer5Path => null;

		public global::UnityEngine.Color FaceLayer5Color => default(global::UnityEngine.Color);

		public string FaceLayer6Path => null;

		public global::UnityEngine.Color FaceLayer6Color => default(global::UnityEngine.Color);

		public string BodyLayer1Path => null;

		public global::UnityEngine.Color BodyLayer1Color => default(global::UnityEngine.Color);

		public string BodyLayer2Path => null;

		public global::UnityEngine.Color BodyLayer2Color => default(global::UnityEngine.Color);

		public string BodyLayer3Path => null;

		public global::UnityEngine.Color BodyLayer3Color => default(global::UnityEngine.Color);

		public string BodyLayer4Path => null;

		public global::UnityEngine.Color BodyLayer4Color => default(global::UnityEngine.Color);

		public string BodyLayer5Path => null;

		public global::UnityEngine.Color BodyLayer5Color => default(global::UnityEngine.Color);

		public string BodyLayer6Path => null;

		public global::UnityEngine.Color BodyLayer6Color => default(global::UnityEngine.Color);

		public string Accessory1Path => null;

		public global::UnityEngine.Color Accessory1Color => default(global::UnityEngine.Color);

		public string Accessory2Path => null;

		public global::UnityEngine.Color Accessory2Color => default(global::UnityEngine.Color);

		public string Accessory3Path => null;

		public global::UnityEngine.Color Accessory3Color => default(global::UnityEngine.Color);

		public string Accessory4Path => null;

		public global::UnityEngine.Color Accessory4Color => default(global::UnityEngine.Color);

		public string Accessory5Path => null;

		public global::UnityEngine.Color Accessory5Color => default(global::UnityEngine.Color);

		public string Accessory6Path => null;

		public global::UnityEngine.Color Accessory6Color => default(global::UnityEngine.Color);

		public string Accessory7Path => null;

		public global::UnityEngine.Color Accessory7Color => default(global::UnityEngine.Color);

		public string Accessory8Path => null;

		public global::UnityEngine.Color Accessory8Color => default(global::UnityEngine.Color);

		public string Accessory9Path => null;

		public global::UnityEngine.Color Accessory9Color => default(global::UnityEngine.Color);

		public object this[string propertyName] => null;

		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}
	}
}
