// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SourceTreeTest_2Target : TargetRules
{
	public SourceTreeTest_2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "SourceTreeTest_2" } );
	}
}
