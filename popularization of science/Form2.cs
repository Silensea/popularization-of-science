using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popularization_of_science
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "名字由来")
            {
                this.tabControl1.SelectedTab = this.tabPage1;            
                tabControl1.Visible = true;
            }
            if (e.Node.Text == "标准定义")
            {
                this.tabControl1.SelectedTab = this.tabPage2;  
                tabControl1.Visible = true;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            treeView1.Focus();
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if ((e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.Bounds);
                e.Graphics.DrawString(e.Node.Text, treeView1.Font, new SolidBrush(Color.Black), e.Bounds.Location);
            }
            else
            {
                e.DrawDefault = true;
            }

        }
    }
}
