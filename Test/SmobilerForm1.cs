using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Test
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
        }

        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            pageView1.TemplateControl = new SmobilerUserControl1();
            //给PageView添加显示图片
            DataTable pageTable = new DataTable();
            
            pageTable.Columns.Add("Picture"); 
            pageTable.Rows.Add("1.png");
            pageTable.Rows.Add("2.png");
            if (pageTable.Rows.Count > 0)
            {
                pageView1.DataSource = pageTable;
                pageView1.DataBind();
            }
           
        }

        private void button1_Press(object sender, EventArgs e)
        {
            MessageBox.Show("Hello word!!");
        } 
    }
}