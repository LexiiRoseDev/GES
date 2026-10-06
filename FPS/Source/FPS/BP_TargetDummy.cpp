// Fill out your copyright notice in the Description page of Project Settings.


#include "BP_TargetDummy.h"

// Sets default values
ABP_TargetDummy::ABP_TargetDummy()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
	
	UStaticMeshComponent* MyStaticMesh = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("StaticMesh"));
	RootComponent = MyStaticMesh;
	
	UE_LOG(LogTemp, Warning, TEXT("Target Dummy Constructed"));
}

// Called when the game starts or when spawned
void ABP_TargetDummy::BeginPlay()
{
	Super::BeginPlay();
	
	UE_LOG(LogTemp, Warning, TEXT("Target Dummy Spawned"));
}

// Called every frame
void ABP_TargetDummy::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
	
	UE_LOG(LogTemp, Warning, TEXT("Ticked"));
}

