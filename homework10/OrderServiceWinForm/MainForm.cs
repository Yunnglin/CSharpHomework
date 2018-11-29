using program1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OrderServiceWinForm
{
    public partial class MainForm : Form
    {
        //导入数据
        //  public OrderService orderService = OrderService.Import(@"D:\orderService.xml");
        OrderService orderService = new OrderService();
        public string path = @"D:\orderService.xml";
        public string KeyWord { get; set; }
        public MainForm()
        {

            //初始化在第一行
            InitializeComponent();
            //绑定订单数据源
            orderBindingSource.DataSource = orderService.GetAllOrders();

            //绑定查询内容
            queryInput.DataBindings.Add("Text", this, "KeyWord");

            string[] results = Enum.GetNames(typeof(Products));  //对combobox赋值 

            for (int i = 0; i < results.Length; i++)
            {
                comboBox1.Items.Add(results[i]);
            }
        }

        private void queryOrder()
        {
            switch (FindCondition.SelectedIndex)
            {
                case 1:
                    orderBindingSource.DataSource =
                      orderService.GetOrder(queryInput.Text);
                    break;
                case 2:
                    orderBindingSource.DataSource =
                      orderService.FindOrderByClientName(queryInput.Text);
                    break;
                case 3:
                    orderBindingSource.DataSource =
                      orderService.FindOrderByProductBrand(
                          (Products)Enum.Parse(typeof(Products),
                        comboBox1.SelectedItem.ToString()));
                    break;
                default:
                    orderBindingSource.DataSource = orderService.GetAllOrders();
                    break;
            }
            orderBindingSource.ResetBindings(false);
            orderDetailsBindingSource.ResetBindings(false);
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                queryOrder();
            }
            catch (DataException ev)
            {
                MessageBox.Show(ev.Message);
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryInput_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Save()//进行检查
        {

            string phoneNum = @"^\+[0-9]{2}-[0-9]{2}-[0-9]{8}$";
            Regex rx1 = new Regex(phoneNum);
            //  Regex rx2 = new Regex(orderNum);

            //foreach (var o in orderService.GetAllOrders())
            //{
            //    if (o.PhoneNum == null)
            //        break;
            //    Match m1 = rx1.Match(o.PhoneNum);
            //    if (m1.Success == false)
            //    {
            //        MessageBox.Show("电话号码格式错误");
            //        return false;
            //    }
            //}
            //orderService.Export(path);
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("是否保存？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK && Save())
            {
                this.Dispose();//是释放当前的整个窗体资源，不会重复执行formClosing这个方法，所以退出了
            }
            else
            {
                e.Cancel = true;
                //其它选择就不退出
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void ImportBrn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            path = file.FileName;
            orderService = OrderService.Import(path);
            FindBtn_Click(this, null);
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(null);
            editForm.ShowDialog();
            queryOrder();
        }

        private void EditOrder_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current != null)
            {
                EditForm editForm = new EditForm((Order)orderBindingSource.Current);
                editForm.ShowDialog();
                queryOrder();
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {

            if (orderBindingSource.Current != null)
            {
                Order order = (Order)orderBindingSource.Current;
                orderService.RemoveOrder(order.OrderNum);
                queryOrder();
            }
            else
            {
                MessageBox.Show("No Order is selected!");
            }
        }

        private void FindCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FindCondition.SelectedItem.ToString() == "产品名称")
            {
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }
        }
    }
}
