using System;
using Smobiler.Core;
namespace Test
{
    partial class ListViewControl : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.lab_CName = new Smobiler.Core.Controls.Label();
            this.lab_Price = new Smobiler.Core.Controls.Label();
            this.lab_Number = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.numeric1 = new Smobiler.Core.Controls.Numeric();
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lab_CName,
            this.lab_Price,
            this.lab_Number,
            this.numeric1});
            this.panel4.Location = new System.Drawing.Point(82, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 80);
            // 
            // lab_CName
            // 
            this.lab_CName.Bold = true;
            this.lab_CName.DataMember = "conPonName";
            this.lab_CName.DisplayMember = "conPonName";
            this.lab_CName.FontSize = 14F;
            this.lab_CName.Location = new System.Drawing.Point(4, 4);
            this.lab_CName.Name = "lab_CName";
            this.lab_CName.Size = new System.Drawing.Size(90, 20);
            // 
            // lab_Price
            // 
            this.lab_Price.Bold = true;
            this.lab_Price.DataMember = "price";
            this.lab_Price.DisplayMember = "price";
            this.lab_Price.ForeColor = System.Drawing.Color.Red;
            this.lab_Price.Location = new System.Drawing.Point(4, 22);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(81, 21);
            this.lab_Price.Text = "￥";
            // 
            // lab_Number
            // 
            this.lab_Number.DataMember = "number";
            this.lab_Number.DisplayMember = "number";
            this.lab_Number.Location = new System.Drawing.Point(4, 45);
            this.lab_Number.Name = "lab_Number";
            this.lab_Number.Size = new System.Drawing.Size(113, 19);
            this.lab_Number.Text = "月销:";
            // 
            // image1
            // 
            this.image1.DataMember = "Pricture";
            this.image1.DisplayMember = "Pricture";
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(82, 80);
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(63, 52);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(100, 25);
            this.numeric1.ValueChanged += new System.EventHandler(this.numeric1_ValueChanged);
            // 
            // ListViewControl
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4,
            this.image1});
            this.Size = new System.Drawing.Size(250, 80);
            this.Name = "ListViewControl";

        }
        #endregion
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Label lab_CName;
        private Smobiler.Core.Controls.Label lab_Price;
        private Smobiler.Core.Controls.Label lab_Number;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Numeric numeric1;
    }
}