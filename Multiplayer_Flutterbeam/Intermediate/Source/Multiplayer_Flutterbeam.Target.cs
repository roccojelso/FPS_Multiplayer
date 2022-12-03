using UnrealBuildTool;

public class Multiplayer_FlutterbeamTarget : TargetRules
{
	public Multiplayer_FlutterbeamTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Multiplayer_Flutterbeam");
	}
}
