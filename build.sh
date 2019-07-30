#!/bin/bash

dotnet restore
sleep 1
dotnet build
sleep 1
dotnet publish
sleep 1
docker volume create sqlserverdata
sleep 1
docker-compose build