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
    public partial class FooterComponent : UserControl
    {
        public FooterComponent()
        {
            InitializeComponent();
        }

        public Button getbuttonSalvar()
        {
            return this.buttonSalvar;
        }

        public Button getButtonSair()
        {
            return this.buttonSair;
        }
    }
}
