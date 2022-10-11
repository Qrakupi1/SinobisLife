// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class SinobisLife : ModuleRules
{
	public SinobisLife(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateIncludePaths.Add("C:/Program Files/Epic Games/UE_5.0/Engine/Plugins/Marketplace/NinjaCharacter/Source/NinjaCharacter/Private");
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "NinjaCharacter", "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] { "NinjaCharacter" });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
