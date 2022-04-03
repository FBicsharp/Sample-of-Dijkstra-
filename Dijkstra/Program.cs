using System;

// Spanning Tree (MST) algorithm.
// The program is for adjacency
// matrix representation of the graph


int[,] graph ={
    { 0, 1, 2, 0, 0, 0},
    { 1, 0, 0, 5, 1, 0},
    { 2, 0, 0, 2, 3, 0},
    { 0, 5, 2, 0, 2, 2},
    { 0, 1, 3, 2, 0, 1},
    { 0, 0, 0, 2, 1, 0}
};


var dj = new Dijkstra.Dijkstra(graph,6);
dj.Solve();
Console.Read();



