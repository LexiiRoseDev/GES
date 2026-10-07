// Fill out your copyright notice in the Description page of Project Settings.


#include "GravPawn.h"

// Sets default values
AGravPawn::AGravPawn()
{
 	// Set this pawn to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void AGravPawn::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AGravPawn::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void AGravPawn::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

