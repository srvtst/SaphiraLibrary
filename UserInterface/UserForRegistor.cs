﻿using Business.Abstract;
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
    public partial class UserForRegistor : Form
    {
        IUserService _userService;
        public UserForRegistor()
        {
            InitializeComponent();
            _userService = _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnRegisterDto_Click(object sender, EventArgs e)
        {
            try
            {
                UserForRegisterDto userForRegisterDto = new UserForRegisterDto
                {
                    FirstName = txtFirstNameRegister.Text,
                    LastName = txtLastNameRegister.Text,
                    Password = txtPasswordRegister.Text,
                    Email = txtEmailRegister.Text
                };
                _userService.Register(userForRegisterDto, txtPasswordRegister.Text);
                MessageBox.Show("Kullanıcı sisteme üye olmuştur.");
                SaphiraLibrary saphiraLibrary = new SaphiraLibrary();
                saphiraLibrary.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}