using System;
using Smobiler.Core;
namespace Test
{
    partial class CommonForm : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.barcodeScannerButton1 = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button9 = new Smobiler.Core.Controls.Button();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.tob_buy = new Smobiler.Core.Controls.ToolBar();
            this.lan_num = new Smobiler.Core.Controls.Label();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.button7 = new Smobiler.Core.Controls.Button();
            this.button8 = new Smobiler.Core.Controls.Button();
            this.button10 = new Smobiler.Core.Controls.Button();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label2,
            this.barcodeScannerButton1,
            this.label3,
            this.line1});
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 57);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(15, 9);
            this.image1.Name = "image1";
            this.image1.ResourceID = "4";
            this.image1.Size = new System.Drawing.Size(35, 35);
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.FontSize = 20F;
            this.label2.Location = new System.Drawing.Point(59, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            // 
            // barcodeScannerButton1
            // 
            this.barcodeScannerButton1.Location = new System.Drawing.Point(317, 12);
            this.barcodeScannerButton1.Name = "barcodeScannerButton1";
            this.barcodeScannerButton1.ResourceID = "BarcodeScanner";
            this.barcodeScannerButton1.Size = new System.Drawing.Size(35, 35);
            this.barcodeScannerButton1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScannerButton1_BarcodeScanned);
            this.barcodeScannerButton1.Press += new System.EventHandler(this.barcodeScannerButton1_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(281, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 35);
            this.label3.Text = "扫码";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.line1.Location = new System.Drawing.Point(2, 56);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(351, 1);
            // 
            // label1
            // 
            this.label1.FontSize = 18F;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.Text = "堂食点餐";
            // 
            // fontIcon2
            // 
            this.fontIcon2.Location = new System.Drawing.Point(0, 12);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "md-arrow-back";
            this.fontIcon2.Size = new System.Drawing.Size(24, 22);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button4,
            this.button1,
            this.button3,
            this.button2,
            this.button5,
            this.button9});
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 315);
            // 
            // button4
            // 
            this.button4.BindDisplayValueGone = true;
            this.button4.Location = new System.Drawing.Point(181, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 78);
            this.button4.Text = "精品推荐";
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.BindDisplayValueGone = true;
            this.button3.FontSize = 16F;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 78);
            this.button3.Text = "人气热卖";
            this.button3.Press += new System.EventHandler(this.button3_Press_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BindDisplayValueGone = true;
            this.button2.FontSize = 16F;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 78);
            this.button2.Text = "精品套餐";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.BindDisplayValueGone = true;
            this.button5.FontSize = 16F;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 78);
            this.button5.Text = "所有菜单";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.BindDisplayValueGone = true;
            this.button9.FontSize = 16F;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 78);
            this.button9.Text = "精品推荐";
            this.button9.Press += new System.EventHandler(this.button9_Press_1);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.line2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.line2.Location = new System.Drawing.Point(0, 35);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(355, 0);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.line3.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.line3.Location = new System.Drawing.Point(0, 39);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(355, 1);
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.Silver;
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.textBox1.Location = new System.Drawing.Point(52, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Search;
            this.textBox1.SelectOnFocus = true;
            this.textBox1.Size = new System.Drawing.Size(263, 29);
            this.textBox1.WaterMarkText = "请输入搜索内容";
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.panel5});
            this.panel3.Location = new System.Drawing.Point(0, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 81);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tob_buy,
            this.lan_num});
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 80);
            // 
            // tob_buy
            // 
            this.tob_buy.Dock = System.Windows.Forms.DockStyle.None;
            toolBarItem1.IconID = "cart-plus";
            toolBarItem1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem1.MessageText = "numeric1";
            toolBarItem1.Name = "Buy";
            toolBarItem1.SelectIconID = "cart-plus";
            this.tob_buy.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1});
            this.tob_buy.Location = new System.Drawing.Point(18, 13);
            this.tob_buy.Name = "tob_buy";
            this.tob_buy.Size = new System.Drawing.Size(55, 51);
            // 
            // lan_num
            // 
            this.lan_num.Location = new System.Drawing.Point(78, 20);
            this.lan_num.Name = "lan_num";
            this.lan_num.Size = new System.Drawing.Size(100, 35);
            this.lan_num.Text = "label4";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button6,
            this.button7,
            this.button8});
            this.panel5.Location = new System.Drawing.Point(199, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 81);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FontSize = 14F;
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 81);
            this.button6.Text = "请点餐";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FontSize = 14F;
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 81);
            this.button7.Text = "请点餐";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.FontSize = 14F;
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 81);
            this.button8.Text = "去结算";
            this.button8.Press += new System.EventHandler(this.button8_Press);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BorderColor = System.Drawing.Color.Silver;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(52, 113);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 27);
            this.button10.Text = "搜索";
            this.button10.Press += new System.EventHandler(this.button10_Press);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(101, 154);
            this.listView1.Name = "listView1";
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(250, 315);
            this.listView1.TemplateControlName = "ListViewControl";
            // 
            // CommonForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.label1,
            this.fontIcon2,
            this.panel2,
            this.listView1,
            this.line2,
            this.line3,
            this.textBox1,
            this.panel3,
            this.button10});
            this.Size = new System.Drawing.Size(355, 550);
            this.Load += new System.EventHandler(this.CommonForm_Load);
            this.Name = "CommonForm";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.BarcodeScannerButton barcodeScannerButton1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Button button4;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button3;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.Button button5;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.Line line3;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.ToolBar tob_buy;
        private Smobiler.Core.Controls.Panel panel5;
        private Smobiler.Core.Controls.Button button6;
        private Smobiler.Core.Controls.Button button7;
        private Smobiler.Core.Controls.Button button8;
        private Smobiler.Core.Controls.Label lan_num;
        private Smobiler.Core.Controls.Button button9;
        private Smobiler.Core.Controls.Button button10;
        private Smobiler.Core.Controls.ListView listView1;
    }
}