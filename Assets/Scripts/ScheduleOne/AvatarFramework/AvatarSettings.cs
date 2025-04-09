using System;
using System.Collections.Generic;
using FishNet.Serializing.Helping;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "Avatar Settings", menuName = "ScriptableObjects/Avatar Settings", order = 1)]
	public class AvatarSettings : ScriptableObject
	{
		[Serializable]
		public struct LayerSetting
		{
			public string layerPath;

			public Color layerTint;
		}

		[Serializable]
		public class AccessorySetting
		{
			public string path;

			public Color color;
		}

		public Color SkinColor;

		public float Height;

		public float Gender;

		public float Weight;

		public string HairPath;

		public Color HairColor;

		public float EyebrowScale;

		public float EyebrowThickness;

		public float EyebrowRestingHeight;

		public float EyebrowRestingAngle;

		public Color LeftEyeLidColor;

		public Color RightEyeLidColor;

		public Eye.EyeLidConfiguration LeftEyeRestingState;

		public Eye.EyeLidConfiguration RightEyeRestingState;

		public string EyeballMaterialIdentifier;

		public Color EyeBallTint;

		public float PupilDilation;

		public List<LayerSetting> FaceLayerSettings;

		public List<LayerSetting> BodyLayerSettings;

		public List<AccessorySetting> AccessorySettings;

		public bool UseCombinedLayer;

		public string CombinedLayerPath;

		[CodegenExclude]
		public Texture2D ImpostorTexture;

		public float UpperEyelidRestingPosition => 0f;

		public float LowerEyelidRestingPosition => 0f;

		public string FaceLayer1Path => null;

		public Color FaceLayer1Color => default(Color);

		public string FaceLayer2Path => null;

		public Color FaceLayer2Color => default(Color);

		public string FaceLayer3Path => null;

		public Color FaceLayer3Color => default(Color);

		public string FaceLayer4Path => null;

		public Color FaceLayer4Color => default(Color);

		public string FaceLayer5Path => null;

		public Color FaceLayer5Color => default(Color);

		public string FaceLayer6Path => null;

		public Color FaceLayer6Color => default(Color);

		public string BodyLayer1Path => null;

		public Color BodyLayer1Color => default(Color);

		public string BodyLayer2Path => null;

		public Color BodyLayer2Color => default(Color);

		public string BodyLayer3Path => null;

		public Color BodyLayer3Color => default(Color);

		public string BodyLayer4Path => null;

		public Color BodyLayer4Color => default(Color);

		public string BodyLayer5Path => null;

		public Color BodyLayer5Color => default(Color);

		public string BodyLayer6Path => null;

		public Color BodyLayer6Color => default(Color);

		public string Accessory1Path => null;

		public Color Accessory1Color => default(Color);

		public string Accessory2Path => null;

		public Color Accessory2Color => default(Color);

		public string Accessory3Path => null;

		public Color Accessory3Color => default(Color);

		public string Accessory4Path => null;

		public Color Accessory4Color => default(Color);

		public string Accessory5Path => null;

		public Color Accessory5Color => default(Color);

		public string Accessory6Path => null;

		public Color Accessory6Color => default(Color);

		public string Accessory7Path => null;

		public Color Accessory7Color => default(Color);

		public string Accessory8Path => null;

		public Color Accessory8Color => default(Color);

		public string Accessory9Path => null;

		public Color Accessory9Color => default(Color);

		public object this[string propertyName] => null;

		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}
	}
}
