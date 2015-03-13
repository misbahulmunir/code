using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase, price, buildingcount, streetcount;

            Vertex[] vertexs;
            EdgeManager edgesManager;
            testcase = Convert.ToInt32(Console.ReadLine());
            while (testcase > 0)
            {
                //Console.WriteLine("please insert price");
                price = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("please insert building count");
                buildingcount = Convert.ToInt32(Console.ReadLine());
                vertexs = InitVertex(new Vertex[buildingcount], buildingcount);
                //Console.WriteLine("please insert street count");
                streetcount = Convert.ToInt32(Console.ReadLine());
                edgesManager = new EdgeManager();
                while (streetcount > 0)
                {
                   // Console.WriteLine("please insert vertex1 vertex2 and cost");
                    String[] input = Console.ReadLine().Split(' ');
                    edgesManager.Add(vertexs[Convert.ToInt32(input[0]) - 1], vertexs[Convert.ToInt32(input[1]) - 1], Convert.ToInt32(input[2]));
                    streetcount--;
                }
                Console.WriteLine("{0}", (edgesManager.CountCost() * price).ToString());
                testcase--;
            }
           
        }
        public static Vertex[] InitVertex(Vertex[] vertex, int buildingcount)
        {
            
            for (int c = 0; c < buildingcount; c++)
            {
                vertex[c] = new Vertex(c + 1);
            }
            return vertex;
        }
    }
    class Vertex
    {
        private int name;

        public int Name
        {
            get { return name; }
            set { name = value; }
        }
        private int rank;

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        private Vertex root;

        public Vertex Root
        {
            get { return root; }
            set { root = value; }
        }

        public Vertex(int name)
        {
            this.name = name;
            this.root = this;
        }

        public Vertex GetRoot()
        {
            if (this.root != this)
            {
                this.root = this.root.GetRoot();
            }
            return this.root;
        }
        public static void JoinVertex(Vertex root1, Vertex root2)
        {

            if (root2.Rank < root2.Rank)
            {
                root2.Root = root1;
            }
            else
            {
                root1.root = root2;
                if (root1.Rank == root1.Rank)
                {
                    root2.Rank++;
                }
            }
        }
    }
    class Edge : IComparable
    {
        private Vertex v1, v2;
        private int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Vertex V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        public Vertex V2
        {
            get { return v2; }
            set { v2 = value; }
        }
        public Edge(Vertex vertex1, Vertex Vertex2, int cost)
        {
            this.v1 = vertex1;
            this.v2 = Vertex2;
            this.cost = cost;
        }
        public int CompareTo(object obj)
        {
            Edge e = obj as Edge;
            return this.cost.CompareTo(e.Cost);
        }
    }
    class EdgeManager
    {
        private List<Edge> edgeList;

        public List<Edge> EdgeList
        {
            get { return edgeList; }
            set { edgeList = value; }
        }

        public EdgeManager()
        {
            this.edgeList = new List<Edge>();
        }

        public void Add(Vertex vertex1, Vertex vertex2, int cost)
        {
            EdgeList.Add(new Edge(vertex1, vertex2, cost));
            edgeList.Sort();
        }

        public int CountCost()
        {
            int sum = 0;
            foreach (Edge e in edgeList)
            {
                if (e.V1.GetRoot() != e.V2.GetRoot())
                {
                    Vertex.JoinVertex(e.V1, e.V2);
                    sum += e.Cost;
                }
            }
            return sum;
        }
    }
}
