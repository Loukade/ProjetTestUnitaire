#!/bin/bash
git clone https://github.com/Loukade/ProjetTestUnitaire.git
if dotnet build ProjetTestUnitaire/LeGrandRestaurant
then
	if dotnet test ProjetTestUnitaire/LeGrandRestaurant
	then 
		mkdir integration
		cp -r ProjetTestUnitaire/LeGrandRestaurant integration 
	fi
fi
$SHELL
