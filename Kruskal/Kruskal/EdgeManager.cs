using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kruskal
{
    //public class EdgeManager
    //{
    //    private List<Edge> edgeList;

    //    public List<Edge> EdgeList
    //    {
    //        get { return edgeList; }
    //        set { edgeList = value; }
    //    }

    //    public EdgeManager()
    //    {
    //        this.edgeList = new List<Edge>();
    //    }

    //    public void Add(Vertex vertex1, Vertex vertex2, int cost)
    //    {
    //        EdgeList.Add(new Edge(vertex1, vertex2, cost));
    //        edgeList.Sort();
    //    }

    //    public int CountCost()
    //    {
    //        int sum = 0;
    //        foreach (Edge e in edgeList)
    //        {
    //            if (e.V1.GetRoot() != e.V2.GetRoot())
    //            {
    //                Vertex.JoinVertex(e.V1, e.V2);
    //                sum += e.Cost;
    //            }
    //        }
    //        return sum;
    //    }
    //}
}
