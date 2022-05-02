#! /bin/bash
csharpApp=$GET_CURRENT_WEATHER_BIN
filename=$(readlink /proc/self/fd/0)
mapfile -t arrayOfCities
while IFS= read -r line; do 
    arrayOfCities+= $line; 
done
< $filename
arrayOfTemps=()
arrayOfApprovedCities=()
len=${arrayOfCities[@]}
for (( i=0; i<${#arrayOfCities[@]}; i++ )); do
    test=$(${csharpApp} -c ${arrayOfCities[$i]} &)
    if [[ -z $test ]]; then
        echo "Could not pull the weather info for ${arrayOfCities[$i]}"
    else
        IFS='|' read -r -a output <<< "$test"
        temp=${output[1]}
        arrayOfTemps+=($temp)
        arrayOfApprovedCities+=("${arrayOfCities[$i]}")
    fi
done
wait
first=-999
second=-999
third=-999
index1=0
index2=0
index3=0
for (( i=0; i<${#arrayOfTemps[@]}; i++ )); do
    if [[ ${arrayOfTemps[$i]} -gt $first ]]; then
        third=$second
        second=$first
        first=${arrayOfTemps[$i]}
        index1=$i
    elif [[ ${arrayOfTemps[$i]} -gt $second ]]; then
        third=$second
        second=${arrayOfTemps[$i]}
        index2=$i
    elif [[ ${arrayOfTemps[$i]} -gt $third ]]; then
        third=${arrayOfTemps[$i]}
        index3=$i
    fi
done
echo "Three hottest cities are:"
echo "1. ${arrayOfApprovedCities[$index1]} (${first}C)"
echo "2. ${arrayOfApprovedCities[$index2]} (${second}C)"
echo "3. ${arrayOfApprovedCities[$index3]} (${third}C)"