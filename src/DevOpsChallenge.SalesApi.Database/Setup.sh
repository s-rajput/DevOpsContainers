#!/bin/bash

set -e
run_cmd="dotnet run --urls http://*:8000"

until dotnet ef database update; do
>&2 echo "SQL Server is starting up"
sleep 1
done

>&2 echo "SQL Server is up and live" 
