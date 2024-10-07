// Copyright Epic Games, Inc. All Rights Reserved.

#include "FlyingWithAJetpackGameMode.h"
#include "FlyingWithAJetpackCharacter.h"
#include "UObject/ConstructorHelpers.h"

AFlyingWithAJetpackGameMode::AFlyingWithAJetpackGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
