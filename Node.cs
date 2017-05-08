using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TreeEditor
{
    class Node
    {
        public int ID { set; get; }
        public String Name { set; get; }
        public ArrayList paths;



        //Constructor for Node class
        public Node(int Node_ID, String Node_Name)
        {
            paths = new ArrayList();
            ID = Node_ID;
            Name = Node_Name;
        }



        public int getID()
        {
            return ID;
        }



        public String getName()
        {
            return Name;
        }



        public ArrayList getPaths()
        {
            return paths;
        }



        public void setName(String Node_Name)
        {
            Name = Node_Name;
        }



        public void addPath(Path new_Path)
        {
            paths.Add(new_Path);
        }



        public void removePath(int pathID)
        {
            for (int i = 0; i < paths.Count; i++)
            {
              
            }
        }



        public String paths_toString()
        {
            String return_Value;
            return_Value = "(";

            for(int i = 0; i < paths.Count; i++)
            {
                if(i < paths.Count)
                {
                    return_Value = return_Value + ", ";
                } else
                {
                    return_Value = return_Value + ")\r\n";
                }
                
            }

            return return_Value;
        }



        public String toString()
        {
            String return_Value;
            return_Value = "ID: " + Convert.ToString(ID) + "\r\nName: " + Name + "\r\n";
            return_Value = return_Value + "Paths: (";

            for (int i = 0; i < paths.Count; i++)
            {
                if (i < paths.Count)
                {
                    return_Value = return_Value + ", ";
                }
                else
                {
                    return_Value = return_Value + ")\r\n";
                }
            }

            return "";
        }
    }
}
