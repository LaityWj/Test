using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Test
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ListViewControl : Smobiler.Core.Controls.MobileUserControl
    {
        public ListViewControl() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 餐品数量值变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numeric1_ValueChanged(object sender, EventArgs e)
        {
             
        }
    }
}