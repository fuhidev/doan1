using Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSchedule.Algorithm.SplitGroups
{
   public  class SplitID
    {
        public List<Course> getNewListCourse(List<Course> lstC, List<Room> lstR){
            List<Course> lstCourse = new List<Course>();
            String id = "";
            int count = 0;
            if (lstC[0].Type.Equals(Room.LAB))
            {
                lstR = lstR.Where(a => a.Type.Equals(Room.LAB)).ToList();
            }
            else if (lstC[0].Type.Equals(Room.STANDARD))
            {
                lstR = lstR.Where(a => a.Type.Equals(Room.STANDARD)).ToList();
            }
            
            if (lstC.Count > lstR.Count)
            {
                for (int i = 0; i < lstC.Count; i++)
                {
                    if (i < lstR.Count)
                    {
                        id = lstC[i].ID + "" + count;
                        
                    }
                    else if (i >= lstR.Count)//&& (lstC.Count - i) >= lstR.Count
                    {
                        id = lstC[i].ID + "" + (count + 1);
                        if ((i - (lstR.Count * (count+1))) == lstR.Count-1)
                            count++;
                    }
                    //else
                    //{
                    //    id = lstC[i].ID + "" + (count + 2);
                    //}
                    lstCourse.Add(new Course
                    {
                        ID = id,
                        Name = lstC[i].Name,
                        Group = lstC[i].Group,
                        Block = lstC[i].Block,
                        Quantity = lstC[i].Quantity,
                        LstStudent = lstC[i].LstStudent
                    });
                }
            }
            return lstCourse;
        }
    }
}
