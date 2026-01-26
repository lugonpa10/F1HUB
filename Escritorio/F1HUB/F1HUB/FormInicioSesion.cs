using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace F1HUB
{
    public partial class FormInicioSesion : MetroSetForm
    {
        public FormInicioSesion()
        {
            InitializeComponent();

            this.AllowResize = false;
            lblUsuario.IsDerivedStyle = false;      
            lblUsuario.ForeColor = Color.White;     

        }


    }
}
