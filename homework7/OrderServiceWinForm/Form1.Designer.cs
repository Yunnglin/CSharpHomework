namespace OrderServiceWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImportBrn = new System.Windows.Forms.Button();
            this.RemoveOrder = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FindCondition = new System.Windows.Forms.ComboBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.queryInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bindingNavigatorO = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ChosenOrder = new System.Windows.Forms.Label();
            this.EchoLab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorO)).BeginInit();
            this.bindingNavigatorO.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImportBrn);
            this.panel1.Controls.Add(this.RemoveOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FindCondition);
            this.panel1.Controls.Add(this.FindBtn);
            this.panel1.Controls.Add(this.queryInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 102);
            this.panel1.TabIndex = 0;
            // 
            // ImportBrn
            // 
            this.ImportBrn.Location = new System.Drawing.Point(420, 35);
            this.ImportBrn.Name = "ImportBrn";
            this.ImportBrn.Size = new System.Drawing.Size(91, 33);
            this.ImportBrn.TabIndex = 7;
            this.ImportBrn.Text = "导入订单";
            this.ImportBrn.UseVisualStyleBackColor = true;
            this.ImportBrn.Click += new System.EventHandler(this.ImportBrn_Click);
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.Location = new System.Drawing.Point(757, 43);
            this.RemoveOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(124, 34);
            this.RemoveOrder.TabIndex = 6;
            this.RemoveOrder.Text = "删除订单";
            this.RemoveOrder.UseVisualStyleBackColor = true;
            this.RemoveOrder.Click += new System.EventHandler(this.RemoveOrder_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(575, 43);
            this.AddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(124, 34);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "添加订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "查询方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询内容";
            // 
            // FindCondition
            // 
            this.FindCondition.FormattingEnabled = true;
            this.FindCondition.Items.AddRange(new object[] {
            "None",
            "订单号",
            "客户名",
            "产品名称"});
            this.FindCondition.Location = new System.Drawing.Point(109, 14);
            this.FindCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindCondition.Name = "FindCondition";
            this.FindCondition.Size = new System.Drawing.Size(121, 23);
            this.FindCondition.TabIndex = 2;
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(279, 22);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(96, 55);
            this.FindBtn.TabIndex = 1;
            this.FindBtn.Text = "查询";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // queryInput
            // 
            this.queryInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.queryInput.Location = new System.Drawing.Point(109, 52);
            this.queryInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryInput.Name = "queryInput";
            this.queryInput.Size = new System.Drawing.Size(121, 25);
            this.queryInput.TabIndex = 0;
            this.queryInput.TextChanged += new System.EventHandler(this.queryInput_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 510);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 155);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bindingNavigatorO);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 63);
            this.panel5.TabIndex = 2;
            // 
            // bindingNavigatorO
            // 
            this.bindingNavigatorO.AddNewItem = null;
            this.bindingNavigatorO.BindingSource = this.orderBindingSource;
            this.bindingNavigatorO.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorO.DeleteItem = null;
            this.bindingNavigatorO.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorO.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorO.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorO.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorO.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorO.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorO.Name = "bindingNavigatorO";
            this.bindingNavigatorO.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorO.Size = new System.Drawing.Size(390, 27);
            this.bindingNavigatorO.TabIndex = 1;
            this.bindingNavigatorO.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SaveButton);
            this.panel4.Controls.Add(this.ChosenOrder);
            this.panel4.Controls.Add(this.EchoLab);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1063, 92);
            this.panel4.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.Location = new System.Drawing.Point(978, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 92);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChosenOrder
            // 
            this.ChosenOrder.AutoSize = true;
            this.ChosenOrder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderNum", true));
            this.ChosenOrder.Location = new System.Drawing.Point(116, 19);
            this.ChosenOrder.Name = "ChosenOrder";
            this.ChosenOrder.Size = new System.Drawing.Size(55, 15);
            this.ChosenOrder.TabIndex = 1;
            this.ChosenOrder.Text = "[    ]";
            // 
            // EchoLab
            // 
            this.EchoLab.AutoSize = true;
            this.EchoLab.Location = new System.Drawing.Point(27, 20);
            this.EchoLab.Name = "EchoLab";
            this.EchoLab.Size = new System.Drawing.Size(82, 15);
            this.EchoLab.TabIndex = 0;
            this.EchoLab.Text = "选中订单：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 408);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn1,
            this.productsNumDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView2.DataMember = "OrderDetails";
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView2.Location = new System.Drawing.Point(575, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(488, 408);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            // 
            // productsNumDataGridViewTextBoxColumn1
            // 
            this.productsNumDataGridViewTextBoxColumn1.DataPropertyName = "ProductsNum";
            this.productsNumDataGridViewTextBoxColumn1.HeaderText = "Products Number";
            this.productsNumDataGridViewTextBoxColumn1.Name = "productsNumDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Unit Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(program1.Order);
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Clients\' Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorO)).EndInit();
            this.bindingNavigatorO.ResumeLayout(false);
            this.bindingNavigatorO.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FindCondition;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.TextBox queryInput;
        private System.Windows.Forms.Button RemoveOrder;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ChosenOrder;
        private System.Windows.Forms.Label EchoLab;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingNavigator bindingNavigatorO;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ImportBrn;
    }
}

