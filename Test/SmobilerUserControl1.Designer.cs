using System;
using Smobiler.Core;
namespace Test
{
    partial class SmobilerUserControl1 : Smobiler.Core.Controls.MobileUserControl
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
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // image1
            // 
            this.image1.DisplayMember = "Picture";
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(400, 223);
            // 
            // SmobilerUserControl1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1});
            this.Size = new System.Drawing.Size(380, 164);
            this.Load += new System.EventHandler(this.SmobilerUserControl1_Load);
            this.Name = "SmobilerUserControl1";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
    }
}