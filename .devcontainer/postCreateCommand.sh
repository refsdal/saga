#!/bin/bash

# Dotnet Workload Update and install
dotnet workload update
dotnet workload install aspire

# Restore packages
dotnet restore
