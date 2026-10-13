// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "GES_MVP1GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AGES_MVP1GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AGES_MVP1GameMode();
};



