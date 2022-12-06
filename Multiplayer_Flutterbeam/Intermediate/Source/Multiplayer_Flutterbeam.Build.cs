using UnrealBuildTool;

public class Multiplayer_Flutterbeam : ModuleRules
{
	public Multiplayer_Flutterbeam(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
