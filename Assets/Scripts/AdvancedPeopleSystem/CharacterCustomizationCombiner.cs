namespace AdvancedPeopleSystem
{
	public class CharacterCustomizationCombiner
	{
		private class MeshInstance
		{
			public global::System.Collections.Generic.Dictionary<global::UnityEngine.Material, global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterCustomizationCombiner.CombineInstanceWithSM>> combine_instances;

			public global::System.Collections.Generic.List<global::UnityEngine.Material> unique_materials;

			public global::UnityEngine.Mesh combined_new_mesh;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector3> combined_vertices;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector2> combined_uv;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector2> combined_uv2;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector2> combined_uv3;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector2> combined_uv4;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector3> normals;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector4> tangents;

			public global::System.Collections.Generic.Dictionary<global::UnityEngine.Material, global::System.Collections.Generic.List<int>> combined_submesh_indices;

			public global::System.Collections.Generic.List<global::UnityEngine.BoneWeight> combined_bone_weights;

			public global::System.Collections.Generic.List<string> blendShapeNames;

			public global::System.Collections.Generic.List<float> blendShapeValues;

			public global::System.Collections.Generic.Dictionary<global::UnityEngine.Mesh, int> vertex_offset_map;

			public int vertex_index_offset;

			public int current_material_index;
		}

		private struct CombineInstanceWithSM
		{
			public global::UnityEngine.SkinnedMeshRenderer skinnedMesh;

			public global::UnityEngine.CombineInstance instance;
		}

		private struct BlendWeightData
		{
			public global::UnityEngine.Vector3[] deltaVerts;

			public global::UnityEngine.Vector3[] deltaNormals;

			public global::UnityEngine.Vector3[] deltaTangents;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CBlendshapeTransfer_003Ed__11 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::AdvancedPeopleSystem.CharacterCustomizationCombiner.MeshInstance meshInstance;

			public global::UnityEngine.SkinnedMeshRenderer smr;

			public float waitTime;

			public bool yieldUse;

			public int lod;

			private global::AdvancedPeopleSystem.CharacterCustomization _003CcharacterSystem_003E5__2;

			private int _003Cbs_003E5__3;

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
			public _003CBlendshapeTransfer_003Ed__11(int _003C_003E1__state)
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

		private static global::UnityEngine.Matrix4x4[] bindPoses;

		private static global::System.Collections.Generic.List<global::AdvancedPeopleSystem.CharacterCustomizationCombiner.MeshInstance> LODMeshInstances;

		private static global::AdvancedPeopleSystem.CharacterCustomization currentCharacter;

		private static bool useExportToAnotherObject;

		private static bool BlendshapeTransferWork;

		private static global::System.Action<global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer>> _callback;

		private static global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer> returnSkinnedMeshes;

		public static global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer> MakeCombinedMeshes(global::AdvancedPeopleSystem.CharacterCustomization character, global::UnityEngine.GameObject exportInCustomObject = null, float blendshapeAddDelay = 0.001f, global::System.Action<global::System.Collections.Generic.List<global::UnityEngine.SkinnedMeshRenderer>> callback = null)
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::AdvancedPeopleSystem.CharacterCustomizationCombiner._003CBlendshapeTransfer_003Ed__11))]
		private static global::System.Collections.IEnumerator BlendshapeTransfer(global::AdvancedPeopleSystem.CharacterCustomizationCombiner.MeshInstance meshInstance, float waitTime, global::UnityEngine.SkinnedMeshRenderer smr, int lod, bool yieldUse = true)
		{
			return null;
		}
	}
}
