﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SFARM.Views
{
    /// <summary>
    /// MyInfoControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MyInfoControl : UserControl
    {
        public MyInfoControl()
        {
            InitializeComponent();
            TxtUserName.Text = Helpers.UserInfo.USER_NAME;
            TxtUserEmail.Text = Helpers.UserInfo.USER_EMAIL;
            TxtUserTell.Text = Helpers.UserInfo.USER_TELL;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
