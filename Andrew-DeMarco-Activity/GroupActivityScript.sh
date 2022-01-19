# This is a terminal menu example
repeat="true"
skydives=0
scubadives=0

while [ "$repeat" == true ]
do
echo "---------------------------"
echo "Andrew's Adventure MENU"
echo "Enter a number for what you would like to do"
echo "1: Go Skydiving!"
echo "2: Go Scuba diving!"
echo "3: Go to an Amusement Park!"
echo "4: Go to bed (This will EXIT program)"
echo "Enter a number for activity:"
read ans

if [ "$ans" == "1" ]
then
skydives=$(($skydives+1))
echo "Congradulations! You have gone skydiving $skydives time(s)!"
elif [ "$ans" == "2" ]
then
echo "How many minutes did you scbua dive for today?"
read scubatime
scubadives=$(($scubadives+$scubatime))
echo "Nice! That makes $scubadives minute(s) in total!"
elif [ "$ans" == "3" ]
then
echo "What did you ride?"
read amusementRide
echo "Nice! $amusementRide is a great ride!"
elif [ "$ans" == "4" ]
then
echo "Goodnight!"
repeat="false"
else
echo "command not found"
fi
done

