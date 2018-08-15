using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITIX.ViewForm.Components
{
    public partial class HeaderComponent : UserControl
    {
        public HeaderComponent()
        {
            InitializeComponent();
        }

        private void HeaderComponent_Load(object sender, EventArgs e)
        {
            textBoxId.Text = "0";
        }

        public TextBox getTextBoxId()
        {
            return this.textBoxId;
        }
    }
}
