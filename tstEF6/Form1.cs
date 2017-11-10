using DAL.Data.Context;
using DAL.Data.Handlers;
using DAL.Domain.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tstEF6
{
    public partial class Form1 : Form
    {
        StudentDataHandler dh;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dh = new StudentDataHandler();
        }

        private void RefreshGrid()
        {
            dgvAllData.DataSource = dh.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dh.Add(
                new Student()
                {
                    Name = "Ahmed",
                    Age = 20,
                    DateOfBirth = null,
                    Height = 120,
                    Weight = 10,
                });

            RefreshGrid();
        }
    }
}
