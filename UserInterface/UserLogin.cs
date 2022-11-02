using Business.Abstract;
using Business.DependencyResolvers.Autofac;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class UserLogin : Form
    {
        IUserService _userService;
        public UserLogin()
        {
            _userService = InstanceFactory.GetInstance<IUserService>();
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserForLoginDto userForLoginDto = new UserForLoginDto
                {
                    Email = txtUserLogin.Text,
                    Password = txtUserPassword.Text
                };
                _userService.Login(userForLoginDto);
                SaphiraLibrary saphiraLibrary = new SaphiraLibrary();
                saphiraLibrary.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UserForRegistor userForRegistor = new UserForRegistor();
            userForRegistor.Show();
            this.Hide();
        }
    }
}