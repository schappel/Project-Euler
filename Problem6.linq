<Query Kind="Statements" />

var upper = 100;
var aggSquares = (2 * upper + 1) * (upper + 1) * upper / 6;
//Enumerable.Range(1,upper).Aggregate( 0, (result, i) => result + (i * i) );
var sum = (upper * (upper + 1))/2; 
//Enumerable.Range(1,upper).Sum();
var aggSquared = sum*sum;
aggSquares.Dump();
aggSquared.Dump();
(aggSquared - aggSquares).Dump();
