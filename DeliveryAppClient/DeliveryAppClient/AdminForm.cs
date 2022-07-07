using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeliveryAppClient
{
    public partial class AdminForm : Form
    {
        User user;
        public AdminForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void btnGetOrdersSDEK_Click(object sender, System.EventArgs e)
        {
            List<Order> orders = APIManager.GetOrdersSDEK(user.role);
            dgvOrders.DataSource = orders;
        }

        private void btnGetOrdersUralTransit_Click(object sender, System.EventArgs e)
        {
            List<Order> orders = APIManager.GetOrdersUralTransit(user.role);
            dgvOrders.DataSource = orders;
        }

        private void btnGetAllOrders_Click(object sender, System.EventArgs e)
        {
            List<Order> ordersSDEK = APIManager.GetOrdersSDEK(user.role);
            List<Order> ordersUralTransit = APIManager.GetOrdersUralTransit(user.role);
            dgvOrders.DataSource = ordersSDEK.Union(ordersUralTransit).ToList();
        }
    }
}
