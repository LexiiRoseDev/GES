// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MVP2 : ModuleRules
{
	public MVP2(ReadOnlyTargetRules Target) : base(Target)
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
			"MVP2",
			"MVP2/Variant_Platforming",
			"MVP2/Variant_Platforming/Animation",
			"MVP2/Variant_Combat",
			"MVP2/Variant_Combat/AI",
			"MVP2/Variant_Combat/Animation",
			"MVP2/Variant_Combat/Gameplay",
			"MVP2/Variant_Combat/Interfaces",
			"MVP2/Variant_Combat/UI",
			"MVP2/Variant_SideScrolling",
			"MVP2/Variant_SideScrolling/AI",
			"MVP2/Variant_SideScrolling/Gameplay",
			"MVP2/Variant_SideScrolling/Interfaces",
			"MVP2/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
