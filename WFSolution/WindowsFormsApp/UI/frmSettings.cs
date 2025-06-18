using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UI
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            this.Text = "Settings";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblMessage = new Label
            {
                Text = "Setting Screen",
                Location = new System.Drawing.Point(150, 130),
                AutoSize = true
            };

            this.Controls.Add(lblMessage);
        }
    }
}
