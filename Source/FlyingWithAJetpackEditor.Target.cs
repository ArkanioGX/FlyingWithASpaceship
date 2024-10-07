// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FlyingWithAJetpackEditorTarget : TargetRules
{
	public FlyingWithAJetpackEditorTarget(TargetInfo Target) : base(Target)
	{
  bOverrideBuildEnvironment = true;
  Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("FlyingWithAJetpack");
	}
}
