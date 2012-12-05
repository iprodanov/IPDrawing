using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Draw
{
    public partial class FineRotationForm : Form
    {
        public FineRotationForm()
        {
            InitializeComponent();
        }

        public int GetAngle()
        {
            return Convert.ToInt16(tbAngle.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
