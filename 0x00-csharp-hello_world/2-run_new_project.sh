#!/usr/bin/env bash
# script to initialize, build and start a new C# project
dotnet new console -n 1-new_project
cd 1-new_project
dotnet build
dotnet run
