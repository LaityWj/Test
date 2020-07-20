using System;
using Smobiler.Core;
namespace Test
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
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
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(34, 108);
            this.image1.Name = "image1";
            this.image1.ResourceID = "1";
            this.image1.Size = new System.Drawing.Size(155, 132);
            // 
            // SmobilerForm2
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1});
            this.Name = "SmobilerForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
    }
}