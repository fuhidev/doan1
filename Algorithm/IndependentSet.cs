using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Database;
using ExamSchedule.Algorithm.Model;

namespace ExamSchedule.Algorithm
{
    public class IndependentSet
    {
        //private Databases _db;
        //private BuildGraph _buildGraph;
        private List<Node> ListNode;

        public IndependentSet(List<Node> listNode)
        {
            this.ListNode = listNode;
        }

        public List<Node> Run(Node node)
        {

            List<Node> indepentSet = new List<Node>();

            indepentSet.Add(node);

            Node n = node;

            while (n != null)
            {

                var adjoinableList = this.SearchAdjonable(indepentSet);
                n = MaxAdjonable(indepentSet, adjoinableList);

                if (n != null) indepentSet.Add(n);
            }
            // xoa dinh dang xet ra khoi tap doc lap tai vi dang tim tap doc lap cua no thi khong can luu giu no lam gi
            indepentSet.Remove(node);
            return indepentSet;

        }

        private Node MaxAdjonable(List<Node> indepentList, IEnumerable<Node> adjList)
        {
            Node result = null;

            List<Node> tmp = new List<Node>(indepentList);

            int max = -1;

            foreach (var node in adjList)
            {
                tmp.Add(node);

                int sum = this.SearchAdjonable(tmp).Count();

                if (sum > max)
                {
                    sum = max;
                    result = node;
                }
            }

            return result;
        }

        private IEnumerable<Node> SearchAdjonable(List<Node> indepentSet)
        {
            foreach (var node in ListNode)
            {

                //neu nhu chua co mau thi moi tim kiem tiep, con neu co mau roi thi no da nam trong tap doc lap khac roi
                if (node.Color == null)
                    //neu nhu la din adjonable cua tap doc lap

                    if (CheckAdjoinable(node, indepentSet))
                    {
                        yield return node;
                    }
            }
        }

        private bool CheckAdjoinable(Node node, List<Node> independentSet)
        {
            bool valid = false;

            foreach (var f in independentSet)
                //neu nhu no la node dang xet hoac no la hang xom cua bat cu dinh nao trong tap doc lap
                if (f.GetNeighBorNodes().Contains(node) || f.Equals(node))
                {
                    valid = true;
                    break;
                }
            return !valid;
        }




    }
}
