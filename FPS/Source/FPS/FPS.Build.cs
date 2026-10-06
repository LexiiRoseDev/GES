// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FPS : ModuleRules
{
	public FPS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FPS",
			"FPS/Variant_Platforming",
			"FPS/Variant_Platforming/Animation",
			"FPS/Variant_Combat",
			"FPS/Variant_Combat/AI",
			"FPS/Variant_Combat/Animation",
			"FPS/Variant_Combat/Gameplay",
			"FPS/Variant_Combat/Interfaces",
			"FPS/Variant_Combat/UI",
			"FPS/Variant_SideScrolling",
			"FPS/Variant_SideScrolling/AI",
			"FPS/Variant_SideScrolling/Gameplay",
			"FPS/Variant_SideScrolling/Interfaces",
			"FPS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
