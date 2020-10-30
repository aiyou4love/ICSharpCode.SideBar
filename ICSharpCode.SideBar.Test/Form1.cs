using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICSharpCode.SideBar.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sideBarControl1_Load(object sender, EventArgs e)
        {
            SideTab tab = sideBarControl1.Tabs.Add("name1");
            tab.DisplayName = "text11";
            tab.CanSaved = false;
            tab.Items.Add("itemName11", "itemText11");
            tab.Items.Add("itemName12", "itemText12");
            tab.Items.Add("itemName13", "itemText13");
            tab.CanBeDeleted = tab.CanDragDrop = false;


            SideTab tab1 = sideBarControl1.Tabs.Add("name2");
            tab1.DisplayName = "text21";
            tab1.CanSaved = false;
            tab1.Items.Add("itemName21", "itemText21");
            tab1.Items.Add("itemName22", "itemText22");
            tab1.Items.Add("itemName23", "itemText23");
            tab1.CanBeDeleted = tab.CanDragDrop = false;
            sideBarControl1.ActiveTab = tab1;

            SideTab tab2 = sideBarControl1.Tabs.Add("name3");
            tab2.DisplayName = "text31";
            tab2.CanSaved = false;
            tab2.Items.Add("itemName31", "itemText31");
            tab2.Items.Add("itemName32", "itemText32");
            tab2.Items.Add("itemName33", "itemText33");
            tab2.CanBeDeleted = tab.CanDragDrop = false;
        }
    }
}
