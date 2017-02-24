//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleTest
//{
//    internal class GraphTest
//    {
//        DataProvider db;
//        Graph g;
//        public GraphTest()
//        {
//            db = new DataProvider();

//            g = new Graph(db);
//            g.BuildGraph();

//            //g.AssignColor();
//            Console.Write(TestGraph());
//            //testStudent();
//            //write(TestGraph(), "D:\\graph.txt");
//        }
//        //string testStudent()
//        //{
//        //    var std = db.ListStudent.First(a => a.ID == "51303415");
//        //    String s = "";
//        //    foreach (var c in std.LstCourse)
//        //    {
//        //        s += c.Name + "\n";
//        //        s += g.ListNode.FirstOrDefault(a => a.Course.Equals(c)).Color + "\n";
//        //    }

//        //    //Console.WriteLine(s);
//        //    return s;
//        //}
//        string TestGraph()
//        {
//            //foreach (var g in graph)
//            //{
//            //    Console.WriteLine("{0}:{1}:{2}", g.Item1.Course.ID, g.Item2.Course.ID, g.Item3);
//            //}
//            string s = "";
//            g.ListNode.Sort((x, y) => string.Compare(x.Name, y.Name));
//            foreach (var n in g.ListNode)
//            {
//                if(n.Color != null)
//                s += n.ToString() + "\n";
//            }
//            return s;
//        }
//        //void write(string s, string fileName)
//        //{
//        //    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName))
//        //    {
//        //        foreach (var n in g.ListNode)
//        //        {
//        //            if (n.Course.Block != -1)
//        //                writer.WriteLine(n);
//        //        }
//        //    }
//        //}
//    }
//}

