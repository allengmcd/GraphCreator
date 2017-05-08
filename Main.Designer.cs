namespace TreeEditor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtAddNodeName = new System.Windows.Forms.TextBox();
            this.txtAddPathName = new System.Windows.Forms.TextBox();
            this.txtAddPathValue = new System.Windows.Forms.TextBox();
            this.cboAddNode1 = new System.Windows.Forms.ComboBox();
            this.cboAddNode2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.cboSelectNode = new System.Windows.Forms.ComboBox();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.btnTraverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(754, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Node";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(140, 493);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Node";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtAddNodeName
            // 
            this.txtAddNodeName.Location = new System.Drawing.Point(754, 24);
            this.txtAddNodeName.Name = "txtAddNodeName";
            this.txtAddNodeName.Size = new System.Drawing.Size(218, 20);
            this.txtAddNodeName.TabIndex = 2;
            // 
            // txtAddPathName
            // 
            this.txtAddPathName.Location = new System.Drawing.Point(754, 132);
            this.txtAddPathName.Name = "txtAddPathName";
            this.txtAddPathName.Size = new System.Drawing.Size(218, 20);
            this.txtAddPathName.TabIndex = 3;
            // 
            // txtAddPathValue
            // 
            this.txtAddPathValue.Location = new System.Drawing.Point(754, 168);
            this.txtAddPathValue.Name = "txtAddPathValue";
            this.txtAddPathValue.Size = new System.Drawing.Size(218, 20);
            this.txtAddPathValue.TabIndex = 4;
            // 
            // cboAddNode1
            // 
            this.cboAddNode1.FormattingEnabled = true;
            this.cboAddNode1.Location = new System.Drawing.Point(754, 206);
            this.cboAddNode1.Name = "cboAddNode1";
            this.cboAddNode1.Size = new System.Drawing.Size(218, 21);
            this.cboAddNode1.TabIndex = 5;
            // 
            // cboAddNode2
            // 
            this.cboAddNode2.FormattingEnabled = true;
            this.cboAddNode2.Location = new System.Drawing.Point(754, 244);
            this.cboAddNode2.Name = "cboAddNode2";
            this.cboAddNode2.Size = new System.Drawing.Size(218, 21);
            this.cboAddNode2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Node #1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Node #2:";
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(754, 289);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(105, 37);
            this.btnAddPath.TabIndex = 12;
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // cboSelectNode
            // 
            this.cboSelectNode.FormattingEnabled = true;
            this.cboSelectNode.Location = new System.Drawing.Point(86, 23);
            this.cboSelectNode.Name = "cboSelectNode";
            this.cboSelectNode.Size = new System.Drawing.Size(218, 21);
            this.cboSelectNode.TabIndex = 13;
            this.cboSelectNode.SelectedIndexChanged += new System.EventHandler(this.cboSelectNode_SelectedIndexChanged);
            // 
            // lbPaths
            // 
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.Location = new System.Drawing.Point(53, 107);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(250, 160);
            this.lbPaths.TabIndex = 14;
            // 
            // btnTraverse
            // 
            this.btnTraverse.Location = new System.Drawing.Point(118, 289);
            this.btnTraverse.Name = "btnTraverse";
            this.btnTraverse.Size = new System.Drawing.Size(105, 37);
            this.btnTraverse.TabIndex = 15;
            this.btnTraverse.Text = "Traverse";
            this.btnTraverse.UseVisualStyleBackColor = true;
            this.btnTraverse.Click += new System.EventHandler(this.btnTraverse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 562);
            this.Controls.Add(this.btnTraverse);
            this.Controls.Add(this.lbPaths);
            this.Controls.Add(this.cboSelectNode);
            this.Controls.Add(this.btnAddPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAddNode2);
            this.Controls.Add(this.cboAddNode1);
            this.Controls.Add(this.txtAddPathValue);
            this.Controls.Add(this.txtAddPathName);
            this.Controls.Add(this.txtAddNodeName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAddNodeName;
        private System.Windows.Forms.TextBox txtAddPathName;
        private System.Windows.Forms.TextBox txtAddPathValue;
        private System.Windows.Forms.ComboBox cboAddNode1;
        private System.Windows.Forms.ComboBox cboAddNode2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.ComboBox cboSelectNode;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.Button btnTraverse;
    }
}

