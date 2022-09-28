using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULO_DE_AREAS
{
    public partial class calculo : Form
    {
        public calculo()
        {
            InitializeComponent();
        }

        private void calculo_Load(object sender, EventArgs e)
        {

        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            ServiceReferenceAreas.WebServiceAREASoapClient ws = new ServiceReferenceAreas.WebServiceAREASoapClient();
            ResultadoCuadrado.Text = ws.CUADRADO(Convert.ToInt32(LADO.Text)).ToString();
            ResultadoTriangulo.Text = ws.TRIANGULO(Convert.ToInt32(BASE.Text), Convert.ToInt32(ALTURA.Text)).ToString();
            ResultadoCirculo.Text = ws.CIRCULO(Convert.ToInt32(RADIO.Text)).ToString();

        }
    }
}
