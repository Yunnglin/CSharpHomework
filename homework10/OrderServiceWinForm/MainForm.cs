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
        // 为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，
        //实现创建订单、删除订单、修改订单、查询订单等功能。
        //要求：
        //（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
        //（2）主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
        //（3）尽量通过数据绑定来实现功能。 注：订单明细可以设置DataMember来绑定。


        //导入数据

        //  public OrderService orderService = OrderService.Import(@"D:\orderService.xml");
        public OrderService orderService = new OrderService();
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

            FindCondition.SelectedIndex = FindCondition.Items.IndexOf("None");

            string[] results = Enum.GetNames(typeof(Products));  //对combobox赋值 

            for (int i = 0; i < results.Length; i++)
            {
                comboBox2.Items.Add(results[i]);
                comboBox1.Items.Add(results[i]);
            }

            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("Apple");

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindCondition.SelectedItem == null)
                    return;
                if (FindCondition.SelectedItem.ToString() == "订单号")
                {

                    orderBindingSource.DataSource = orderService.GetOrder(KeyWord);
                }
                else if (FindCondition.SelectedItem.ToString() == "客户名")
                {
                    orderBindingSource.DataSource = orderService.FindOrderByClientName(KeyWord);
                }
                else if (FindCondition.SelectedItem.ToString() == "产品名称")
                {
                    comboBox1.Visible = true;
                    orderBindingSource.DataSource =
                        orderService.FindOrderByProductBrand(
                            (Products)Enum.Parse(typeof(Products),
                        comboBox1.SelectedItem.ToString()));
                }
                else if (FindCondition.SelectedItem.ToString() == "None")
                {
                    orderBindingSource.DataSource = orderService.GetAllOrders();
                }
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

            foreach (var o in orderService.GetAllOrders())
            {
                Match m1 = rx1.Match(o.PhoneNum);
                if (m1.Success == false)
                {
                    MessageBox.Show("电话号码格式错误");
                    return false;
                }
                //Match m2 = rx1.Match(o.OrderNum);
                //if (m2.Success == false)
                //{
                //    MessageBox.Show("订单号格式错误");
                //    return false;
                //}
            }
            orderService.Export(path);
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
            bindingNavigatorO.AddNewItem.PerformClick();
        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {

            foreach (var o in orderService.GetAllOrders())
            {
                if (o.OrderNum == ChosenOrder.Text)
                {
                    orderService.RemoveOrder(o.OrderNum);
                    break;
                }
            }
            //索引没有值的bug
            BindingSource bs = new BindingSource();
            bs.DataSource = orderService.GetAllOrders();
            orderBindingSource.DataSource = bs;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {

                Rectangle R = dataGridView2.GetCellDisplayRectangle(
                                    dataGridView2.CurrentCell.ColumnIndex,
                                    dataGridView2.CurrentCell.RowIndex, false);

                comboBox2.Location = new Point(dataGridView2.Location.X + R.X,
                    dataGridView2.Location.Y + R.Y);

                comboBox2.Width = R.Width;
                comboBox2.Height = R.Height;
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderDetailsBindingSource.Current == null)
            {
                orderDetailsBindingSource.Add(new OrderDetail());
            }
            ((OrderDetail)orderDetailsBindingSource.Current).Brand =
                (Products)Enum.Parse(typeof(Products), comboBox2.SelectedItem.ToString());
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
