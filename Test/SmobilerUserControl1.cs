﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Test
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class SmobilerUserControl1 : Smobiler.Core.Controls.MobileUserControl
    {
        public SmobilerUserControl1() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void SmobilerUserControl1_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Press(object sender, EventArgs e)
        {

        }
    }
}