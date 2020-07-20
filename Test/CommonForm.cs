using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Model;
using System.Windows.Forms;

namespace Test
{
    partial class CommonForm : Smobiler.Core.Controls.MobileForm
    {
        List<CModel> cModels = new List<CModel>()
        {
          new CModel{ id=1, CName="精品推荐" },
          new CModel{ id=2, CName="人气热卖" },
          new CModel{ id=3, CName="精品套餐" },
          new CModel{ id=4, CName="所有菜单" },
          new CModel{ id=5, CName="主食" },
          new CModel{ id=6, CName="酒食饮品" },
        };
        List<Food> foods = new List<Food>()
        {
          new Food{ id=1, ConPonName="酸辣土豆丝1", Pricture="1.png", price=25, number=3000,cid=2 },
          new Food{ id=2, ConPonName="酸辣土豆丝2", Pricture="2.png", price=25, number=3000,cid=1},
          new Food{ id=3, ConPonName="酸辣土豆丝3", Pricture="1.png", price=25, number=3000,cid=2},
          new Food{ id=4, ConPonName="酸辣土豆丝4", Pricture="2.png", price=25, number=3000,cid=1},
          new Food{ id=5, ConPonName="酸辣土豆丝5", Pricture="1.png", price=25, number=3000,cid=2},
          new Food{ id=6, ConPonName="酸辣土豆丝6", Pricture="2.png", price=25, number=3000,cid=1},
        };
        public CommonForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void barcodeScannerButton1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {

                string s = e.Value;
                //进行其他操作 
                this.label2.Text = s + "桌";
                MessageBox.Show(s);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 扫码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScannerButton1_Press(object sender, EventArgs e)
        {
            //MessageBox.Show("世界你好！！");
        }

        private void button1_Press(object sender,ButtonBase e/*, EventArgs e*/)
        {
            //if (e.Name== "精品推荐")
            //{
            //    CouPonList();
            //}
            string tname = "精品推荐";
            if (this.button1.Text == tname)
            {
                CouPonList();
            }

        } 
        private void CommonForm_Load(object sender, EventArgs e)
        {
            CouPonList();
        }
        public void CouPonList()
        { 

            DataTable tb = new DataTable();
            tb.Columns.Add("id", typeof(System.Int32));
            tb.Columns.Add("Pricture", typeof(System.String));
            tb.Columns.Add("conPonName", typeof(System.String));
            tb.Columns.Add("price", typeof(System.Decimal));
            tb.Columns.Add("number", typeof(System.Int32));
            tb.Rows.Add(1, "2.png", "酸辣土豆丝", 30, 4000);

            tb.Rows.Add(2, "1.png", "Yes辣条", 20, 4000);

            tb.Rows.Add(3, "2.png", "Yes烧饭", 34, 1400);

            tb.Rows.Add(4, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(5, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(6, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(7, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(8, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(9, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(10, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(11, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(12, "1.png", "Yes炒饭", 20, 3000);
            tb.Rows.Add(13, "1.png", "Yes炒饭", 20, 3000);
            listView1.Rows.Clear();
            if (tb.Rows.Count > 0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }


        } 
       /// <summary>
       /// 去结算
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button8_Press(object sender, EventArgs e)
        {

        }

        private void button3_Press(object sender, EventArgs e)
        {
            //if (e.Name == "热气热卖")
            //{
            //    CouPonList();
            //}
            DataTable tb = new DataTable();
            tb.Columns.Add("id", typeof(System.Int32));
            tb.Columns.Add("Pricture", typeof(System.String));
            tb.Columns.Add("conPonName", typeof(System.String));
            tb.Columns.Add("price", typeof(System.Decimal));
            tb.Columns.Add("number", typeof(System.Int32));
            tb.Rows.Add(2, "1.png", "Yes土豆丝", 20, 4000);
            listView1.Rows.Clear();
            if (tb.Rows.Count > 0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }
        }

        private void button9_Press(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Press(object sender, EventArgs e)
        {
            if (this.textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("请输入你要搜索的菜品");

            }
            else
            {
                MessageBox.Show("你真棒！！！");
            }
        }

        private void numeric1_ValueChanged(object sender, EventArgs e)
        {
            ListViewControl viewControl = new ListViewControl();
            
        }
        //菜品分类时间
        private void button9_Press_1(object sender, EventArgs e)
        {
            this.button9.BackColor = System.Drawing.Color.White;
        }

        private void button3_Press_1(object sender, EventArgs e)
        {
            this.button3.BackColor = System.Drawing.Color.White;
            DataTable tb = new DataTable();
            tb.Columns.Add("id", typeof(System.Int32));
            tb.Columns.Add("Pricture", typeof(System.String));
            tb.Columns.Add("conPonName", typeof(System.String));
            tb.Columns.Add("price", typeof(System.Decimal));
            tb.Columns.Add("number", typeof(System.Int32));
            tb.Rows.Add(2, "1.png", "Yes土豆丝", 20, 4000);
            listView1.Rows.Clear();
            if (tb.Rows.Count > 0)
            {
                listView1.DataSource = tb;
                listView1.DataBind();
            }
        }
    }
}