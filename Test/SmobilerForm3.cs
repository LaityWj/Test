using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Test
{
    partial class SmobilerForm3 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm3() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            MessageBox.Show("王晋是一个傻子");
        }
    }
}