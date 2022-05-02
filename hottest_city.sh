#! /bin/bash
test=$(./GetCurrentWeather/bin/Debug/net6.0/GetCurrentWeather -c London -u metric)
IFS='|' read -r -a array <<< "$test"
temp=${array[1]}
echo $temp