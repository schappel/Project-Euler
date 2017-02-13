<Query Kind="Statements" />

Enumerable.Range(0,1000).Aggregate( 0, (total, i) => i % 3 == 0 || i % 5 == 0 ? total + i : total).Dump();