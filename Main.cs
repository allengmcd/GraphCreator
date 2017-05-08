using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace TreeEditor
{
    public partial class Main : Form
    {
        ArrayList nodes;
        Hashtable nodes_Hash;
        protected int counter_nodes;

        ArrayList paths;
        Hashtable paths_Hash;
        protected int counter_path;


        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Node new_Node = new Node(counter_nodes,txtAddNodeName.Text.Trim());
            nodes.Add(new_Node);
            nodes_Hash.Add(counter_nodes, new_Node);
            counter_nodes++;

            ArrayList node1_ArrayList = new ArrayList();
            ArrayList node2_ArrayList = new ArrayList();
            ArrayList selectNode_ArrayList = new ArrayList();


            for (int i = 0; i < nodes.Count; i++)
            {
                node1_ArrayList.Add( nodes[i]);
                node2_ArrayList.Add(nodes[i]);
                selectNode_ArrayList.Add(nodes[i]);
            }

            cboAddNode1.DataSource = null;
            cboAddNode1.ValueMember = "ID";
            cboAddNode1.DisplayMember = "Name";
            cboAddNode1.DataSource = node1_ArrayList;

            cboAddNode2.DataSource = null;
            cboAddNode2.ValueMember = "ID";
            cboAddNode2.DisplayMember = "Name";
            cboAddNode2.DataSource = node2_ArrayList;

            cboSelectNode.DataSource = null;
            cboSelectNode.ValueMember = "ID";
            cboSelectNode.DisplayMember = "Name";
            cboSelectNode.DataSource = selectNode_ArrayList;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            Node node1 = (Node)nodes_Hash[Convert.ToInt32(cboAddNode1.SelectedValue)];
            Node node2 = (Node)nodes_Hash[Convert.ToInt32(cboAddNode2.SelectedValue)];
            Path new_Path = new Path(counter_path, txtAddPathName.Text.Trim(), Convert.ToInt32(txtAddPathValue.Text), node1, node2);
            paths_Hash.Add(counter_path, new_Path);
            counter_path++;
            node1.addPath(new_Path);
            node2.addPath(new_Path);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            nodes = new ArrayList();
            nodes_Hash = new Hashtable();
            counter_nodes = 0;

            paths = new ArrayList();
            paths_Hash = new Hashtable();
            counter_path = 0;
        }

        private void cboSelectNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbPaths.DataSource = null;
                Node selected_Node = (Node)nodes_Hash[Convert.ToInt32(cboSelectNode.SelectedValue)];
                lbPaths.DisplayMember = "Name";
                lbPaths.ValueMember = "ID";
                lbPaths.DataSource = selected_Node.getPaths();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnTraverse_Click(object sender, EventArgs e)
        {

            Path selected_path = (Path)paths_Hash[Convert.ToInt32(lbPaths.SelectedValue)];
            Node new_node = selected_path.TraverseNode(Convert.ToInt32(cboSelectNode.SelectedValue));
            cboSelectNode.SelectedValue = new_node.ID;
        }
    }
}
