#!/usr/bin/env bash
# script to initialize and build a new C# project
dotnet new console -n 1-new_project
cd 1-new_project
dotnet build
