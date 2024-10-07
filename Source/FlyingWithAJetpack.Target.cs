// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FlyingWithAJetpackTarget : TargetRules
{
	public FlyingWithAJetpackTarget(TargetInfo Target) : base(Target)
	{
  bOverrideBuildEnvironment = true;
  Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("FlyingWithAJetpack");
	}
}
