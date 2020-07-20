using Smobiler.Core;

namespace Test
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.pageView1 = new Smobiler.Core.Controls.PageView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.Lab_First = new Smobiler.Core.Controls.Label();
            // 
            // pageView1
            // 
            this.pageView1.Interval = 1;
            this.pageView1.IsLoop = true;
            this.pageView1.Location = new System.Drawing.Point(0, 35);
            this.pageView1.Name = "pageView1";
            this.pageView1.Size = new System.Drawing.Size(400, 223);
            this.pageView1.TemplateControlName = "SmobilerUserControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "你好世界";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // Lab_First
            // 
            this.Lab_First.Bold = true;
            this.Lab_First.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.Lab_First.FontSize = 24F;
            this.Lab_First.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Lab_First.Name = "Lab_First";
            this.Lab_First.Size = new System.Drawing.Size(400, 35);
            this.Lab_First.Text = "首页";
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pageView1,
            this.button1,
            this.Lab_First});
            this.Size = new System.Drawing.Size(380, 750);
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.PageView pageView1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label Lab_First;
    }
}