// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FlyingWithAJetpack : ModuleRules
{
	public FlyingWithAJetpack(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
