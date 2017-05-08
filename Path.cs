using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEditor
{
    class Path
    {
        public int ID { set; get; }
        public String Name { set; get; }
        public int value { set; get; }
        Node node1;
        Node node2;

        public Path(int path_ID, String path_Name, int path_value, Node path_Node1, Node path_Node2)
        {
            ID = path_ID;
            Name = path_Name;
            value = path_value;
            node1 = path_Node1;
            node2 = path_Node2;
        }


        public int getID()
        {
            return ID;
        }



        public String getName()
        {
            return Name;
        }


        public int getValue()
        {
            return value;
        }



        public Node getNode(int NodeID)
        {
            if(node1.getID() == NodeID)
            {
                return node1;
            }
            else if(node2.getID() == NodeID)
            {
                return node2;
            }

            return null;
        }


        public Node TraverseNode(int NodeID)
        {
            if (node1.getID() == NodeID)
            {
                return node2;
            }
            else if (node2.getID() == NodeID)
            {
                return node1;
            }

            return null;
        }



        public void setName(String path_Name)
        {
            Name = path_Name;
        }



        public void setValue(int path_Value)
        {
            value = path_Value;
        }
    }
}
