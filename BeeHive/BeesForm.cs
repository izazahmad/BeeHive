using BeeHive.Bees;
using BeeHive.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHive
{
    public partial class BeesForm : Form
    {
        
       
        public BeesForm()
        {
            InitializeComponent();
        }

        BeeService service = new BeeService();
        //method to populate data in list view
        private void PopulateListView(List<Bee> beeList)
        {
            //if list count and list view item not match than add 3 subitems in List
            if (beeList.Count != lstViewBees.Items.Count)
            {
                lstViewBees.Items.Clear();
                for (int i = 0; i < beeList.Count; i++)
                {
                    ListViewItem bee = new ListViewItem();
                    bee.Text = (i + 1).ToString();
                    bee.SubItems.Add("");
                    bee.SubItems.Add("");
                    bee.SubItems.Add("");
                    this.lstViewBees.Items.Add(bee);
                }
            }
            for (int i = 0; i < beeList.Count; i++)
            {
                ListViewItem item = this.lstViewBees.Items[i];
                item.SubItems[1].Text = beeList[i].BeeType;
                item.SubItems[2].Text = beeList[i].Health + "%";
                //if status return true, it display Dead. otherwise it display Alive
                item.SubItems[3].Text = beeList[i].Status() ? "Dead" : "Alive";
                //Blue color if Status is Alive and Display in Red color if Status is Dead
                item.ForeColor = beeList[i].Status() ? Color.Red : Color.Blue;
            }
        }
        private void BeesForm_Load(object sender, EventArgs e)
        {
            PopulateListView(service.CreateBeesList());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateListView(service.CreateBeesList());
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            PopulateListView(service.Attack());

        }

    }
}
