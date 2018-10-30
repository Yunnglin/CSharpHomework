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

namespace OrderServiceWinForm
{
    public partial class Form1 : Form
    {
        // 为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，
        //实现创建订单、删除订单、修改订单、查询订单等功能。
        //要求：
        //（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
        //（2）主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
        //（3）尽量通过数据绑定来实现功能。 注：订单明细可以设置DataMember来绑定。


            //导入数据
        public OrderService orderService = OrderService.Import(@"D:\orderService.xml");
        public string KeyWord { get; set; }

        public Form1()
        {
            InitializeComponent();
            //绑定订单数据源
            orderBindingSource.DataSource = orderService.Orders;
          
            //绑定查询内容
            queryInput.DataBindings.Add("Text", this, "KeyWord");

            FindCondition.SelectedIndex = FindCondition.Items.IndexOf("None");

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindCondition.SelectedItem == null)
                    return;
                if (FindCondition.SelectedItem.ToString() == "订单号")
                {
                    orderBindingSource.DataSource = orderService.FindOrderByOrderNum(KeyWord);
                }
                else if (FindCondition.SelectedItem.ToString() == "客户名")
                {
                    orderBindingSource.DataSource = orderService.FindOrderByClientName(KeyWord);
                }
                else if (FindCondition.SelectedItem.ToString() == "产品名称")
                {
                    orderBindingSource.DataSource = orderService.FindOrderByProductBrand((Products)Enum.Parse(typeof(Products), KeyWord));
                }
                else if(FindCondition.SelectedItem.ToString() == "None")
                {
                    orderBindingSource.DataSource = orderService.Orders;
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

        private void Save()
        {
            orderService.Export(@"D:\orderService.xml");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("是否保存？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                Save();
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
    }
}
