﻿bool isSnowing = true;
bool isGoingOutside = true;
//if(true/false value)
//{
// body of the code, execute this code if above is true
//}
if(isSnowing)
{
    Console.WriteLine("It is snowing out!");
}

if(isSnowing && isGoingOutside)
{
    Console.WriteLine("Better wear some snow boots!!!");
}

if(!isSnowing || !isGoingOutside)
{
    Console.WriteLine("I do not need any boots!");
}

if(isSnowing ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside once the snow stops");
}

if(!isSnowing){
    Console.WriteLine("There is no need to shovel snow!!");
}
else{
    Console.WriteLine("I guess I need to shovel the snow!");
}

if(isSnowing){
    Console.WriteLine("I guess I have to go clear off the car");
}
else if(!isSnowing){
    Console.WriteLine("I don't want to clear off the car!");
}
else{
    Console.WriteLine("I don't know what we are even talking about");
}