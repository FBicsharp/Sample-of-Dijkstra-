using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Dijkstra
    {


        int[,] _graph;
        int _startVertics;//not implemented yet
        int[] _distance;
        bool[] _visited;
        int _vertices;



        public Dijkstra(int[,] graph, int Nveritces)
        {
            _graph = graph;
            _vertices = Nveritces;

            InitializeStrucutre(0);

        }

        private void InitializeStrucutre(int startPoint=0)
        {
            _startVertics = 0;            
            _distance = new int[_vertices];
            _visited = new bool[_vertices];
            for (int i = 0; i < _vertices; i++)                
            {
                _distance[i] = int.MaxValue;
                _visited[i] = false;                
            }
            _distance[startPoint] = 0;//starting poin is current 0

        }
        





        public int[] Solve()
        {
            for (int k = 0; k < _vertices; k++)
            {
                int m = miniDist();
                _visited[m] = true;
                for (int i = 0;  i< _vertices; i++)
                {
                    // find nod near m and not visited yet and upadte the distance of them
                    if (!_visited[i] && _graph[m,i]!=0 
                        && _distance[m] != int.MaxValue
                        && _distance[m] + _graph[m,i] < _distance[i])
                    {
                        _distance[i] = _distance[m] + _graph[m,i];
                    }
                }
            }

            for (int k = 0; k < _vertices; k++)//debug
            {
                Console.WriteLine($"Node {k}->"+_distance[k]);
            }

            return _distance;


        }

        int miniDist() 
        {
            int minimum = int.MaxValue;
            int ind=-1;

            for (int k = 0; k < _vertices; k++)
            {
                if (_visited[k] == false && _distance[k] <= minimum)
                {
                    minimum = _distance[k];
                    ind = k;
                }
            }
            return ind;
        }








    }
}
