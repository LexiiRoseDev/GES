// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GES_MVP1 : ModuleRules
{
	public GES_MVP1(ReadOnlyTargetRules Target) : base(Target)
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
			"GES_MVP1",
			"GES_MVP1/Variant_Platforming",
			"GES_MVP1/Variant_Platforming/Animation",
			"GES_MVP1/Variant_Combat",
			"GES_MVP1/Variant_Combat/AI",
			"GES_MVP1/Variant_Combat/Animation",
			"GES_MVP1/Variant_Combat/Gameplay",
			"GES_MVP1/Variant_Combat/Interfaces",
			"GES_MVP1/Variant_Combat/UI",
			"GES_MVP1/Variant_SideScrolling",
			"GES_MVP1/Variant_SideScrolling/AI",
			"GES_MVP1/Variant_SideScrolling/Gameplay",
			"GES_MVP1/Variant_SideScrolling/Interfaces",
			"GES_MVP1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
