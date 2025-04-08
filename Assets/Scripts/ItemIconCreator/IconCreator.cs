namespace ItemIconCreator
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
	[global::UnityEngine.DisallowMultipleComponent]
	public class IconCreator : global::UnityEngine.MonoBehaviour
	{
		public enum SaveLocation
		{
			persistentDataPath = 0,
			dataPath = 1,
			projectFolder = 2,
			custom = 3
		}

		public enum Mode
		{
			Automatic = 0,
			Manual = 1
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCaptureFrame_003Ed__30 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ItemIconCreator.IconCreator _003C_003E4__this;

			public string objectName;

			public int i;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CCaptureFrame_003Ed__30(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		protected bool isCreatingIcons;

		public bool useDafaultName;

		public bool includeResolutionInFileName;

		public string iconFileName;

		public global::ItemIconCreator.IconCreator.SaveLocation pathLocation;

		public global::ItemIconCreator.IconCreator.Mode mode;

		public string folderName;

		public bool useTransparency;

		public bool lookAtObjectCenter;

		public bool dynamicFov;

		public float fovOffset;

		protected string finalPath;

		private global::UnityEngine.Vector3 mousePostion;

		public global::UnityEngine.KeyCode nextIconKey;

		protected bool CanMove;

		public bool preview;

		protected global::UnityEngine.Camera whiteCam;

		protected global::UnityEngine.Camera blackCam;

		public global::UnityEngine.Camera mainCam;

		protected global::UnityEngine.Texture2D texBlack;

		protected global::UnityEngine.Texture2D texWhite;

		protected global::UnityEngine.Texture2D finalTexture;

		private global::UnityEngine.CameraClearFlags originalClearFlags;

		protected global::UnityEngine.Transform currentObject;

		private void Awake()
		{
		}

		protected void Initialize()
		{
		}

		protected void DeleteCameras()
		{
		}

		public virtual void BuildIcons()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ItemIconCreator.IconCreator._003CCaptureFrame_003Ed__30))]
		protected global::System.Collections.IEnumerator CaptureFrame(string objectName, int i)
		{
			return null;
		}

		protected virtual void Update()
		{
		}

		private void RenderCamToTexture(global::UnityEngine.Camera cam, global::UnityEngine.Texture2D tex)
		{
		}

		private void CreateBlackAndWhiteCameras()
		{
		}

		protected void CreateNewFolderForIcons()
		{
		}

		public string GetFinalFolder()
		{
			return null;
		}

		private void WriteScreenImageToTexture(global::UnityEngine.Texture2D tex)
		{
		}

		private void CalculateOutputTexture()
		{
		}

		private void SavePng(string name, int i)
		{
		}

		public string GetFileName(string name, int i)
		{
			return null;
		}

		private void CacheAndInitialiseFields()
		{
		}

		protected void UpdateFOV(global::UnityEngine.GameObject targetItem)
		{
		}

		protected void UpdateFOV(float value)
		{
		}

		protected void LookAtTargetCenter(global::UnityEngine.GameObject targetItem)
		{
		}

		private float GetTargetFov(global::UnityEngine.GameObject a)
		{
			return 0f;
		}

		private global::System.Collections.Generic.List<global::UnityEngine.Renderer> GetRenderers(global::UnityEngine.GameObject obj)
		{
			return null;
		}

		private global::UnityEngine.Vector3 GetMeshCenter(global::UnityEngine.GameObject a)
		{
			return default(global::UnityEngine.Vector3);
		}

		protected void RevealInFinder()
		{
		}

		public virtual bool CheckConditions()
		{
			return false;
		}

		private string GetBaseLocation()
		{
			return null;
		}

		private void OnValidate()
		{
		}
	}
}
