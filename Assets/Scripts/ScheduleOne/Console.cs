namespace ScheduleOne
{
	public class Console : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Console>
	{
		public abstract class ConsoleCommand
		{
			public abstract string CommandWord { get; }

			public abstract string CommandDescription { get; }

			public abstract string ExampleUsage { get; }

			public abstract void Execute(global::System.Collections.Generic.List<string> args);
		}

		public class SetTimeCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SpawnVehicleCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class AddItemToInventoryCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ClearInventoryCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ChangeCashCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ChangeOnlineBalanceCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetMoveSpeedCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetJumpMultiplier : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetPropertyOwned : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class Teleport : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class PackageProduct : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetStaminaReserve : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class RaisedWanted : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class LowerWanted : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ClearWanted : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetHealth : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetEnergy : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class FreeCamCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class Save : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetTimeScale : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetVariableValue : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetQuestState : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetQuestEntryState : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetEmotion : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetUnlocked : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetRelationship : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class AddEmployeeCommand : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetDiscovered : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class GrowPlants : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetLawIntensity : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetQuality : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetQuantity : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class Bind : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class Unbind : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ClearBinds : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class HideUI : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class GiveXP : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class Disable : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class Enable : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class EndTutorial : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class DisableNPCAsset : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ShowFPS : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class HideFPS : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ClearTrash : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class PlayCutscene : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetGravityMultiplier : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetRegionUnlocked : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class ForceSleep : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class DestroyNPCs : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetDayDuration : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		public class SetPoliceIgnorePlayers : global::ScheduleOne.Console.ConsoleCommand
		{
			public override string CommandWord => null;

			public override string CommandDescription => null;

			public override string ExampleUsage => null;

			public override void Execute(global::System.Collections.Generic.List<string> args)
			{
			}
		}

		[global::System.Serializable]
		public class LabelledGameObject
		{
			public string Label;

			public global::UnityEngine.GameObject GameObject;
		}

		public global::UnityEngine.Transform TeleportPointsContainer;

		public global::System.Collections.Generic.List<global::ScheduleOne.Console.LabelledGameObject> LabelledGameObjectList;

		[global::UnityEngine.Tooltip("Commands that run on startup (Editor only)")]
		public global::System.Collections.Generic.List<string> startupCommands;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Console.ConsoleCommand> Commands;

		private static global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Console.ConsoleCommand> commands;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.KeyCode, string> keyBindings;

		private static global::ScheduleOne.PlayerScripts.Player player => null;

		private static void LogCommandError(string error)
		{
		}

		private static void LogUnrecognizedFormat(string[] correctExamples)
		{
		}

		protected override void Awake()
		{
		}

		private void RunStartupCommands()
		{
		}

		[global::UnityEngine.HideInCallstack]
		public static void Log(object message, global::UnityEngine.Object context = null)
		{
		}

		[global::UnityEngine.HideInCallstack]
		public static void LogWarning(object message, global::UnityEngine.Object context = null)
		{
		}

		[global::UnityEngine.HideInCallstack]
		public static void LogError(object message, global::UnityEngine.Object context = null)
		{
		}

		public static void SubmitCommand(global::System.Collections.Generic.List<string> args)
		{
		}

		public static void SubmitCommand(string args)
		{
		}

		public void AddBinding(global::UnityEngine.KeyCode key, string command)
		{
		}

		public void RemoveBinding(global::UnityEngine.KeyCode key)
		{
		}

		public void ClearBindings()
		{
		}

		private void Update()
		{
		}
	}
}
