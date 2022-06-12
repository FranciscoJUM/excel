using Appcore.Interface;
using Dominio.Entities;
using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto1._0
{
    public partial class Depreciacion : Form
    {
        IDepreciationService dep;
        public Depreciacion(IDepreciationService dep)
        {
            this.dep = dep;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                MessageBox.Show($"El valor inicial: ({numericUpDown1.Value}) no puede ser menor al valor residual( {numericUpDown2.Value})");
            }
            else
            {
                if(comboBox2.SelectedIndex ==  0 )
                {
                    double valor = (double)numericUpDown1.Value;
                    double vr = (double)numericUpDown2.Value;
                    int vida = 10;
                    List<Depreciations> depre = dep.Depreciacion(valor, vr, vida);
                }
            }
        }

        private void Depreciacion_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetValues(typeof(VidaUtil)).Cast<object>().ToArray());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }
    }
}
