using System;
using System.Windows.Forms;

namespace waRecursividade
{
    public partial class frmRecursividade : Form
    {
        public frmRecursividade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsRecursividade clsR = new clsRecursividade();

            // Colocando em uma única função, fica aqui:
            // Putting it in a single function, stay here:
            txtResultado.Text = clsR.Recursividade(Convert.ToInt32(nudNumeroFinal.Value)).ToString();

            // ---------------------------------------------------
            // Mas eu gostaria de ver cada conta, passo a passo:
            // But I would like to see each account, step by step:
            int intNumeroFinal = 0;
            int ant = 0;

            lstResultado.Items.Clear();

            intNumeroFinal = Convert.ToInt32(nudNumeroFinal.Value);
            
            for (int i = 1; i <= intNumeroFinal; i++)
            {
                lstResultado.Items.Add("Número Contador - Number Count: " + i.ToString());
                lstResultado.Items.Add("Número Anterior - Number Previous: " + ant.ToString());
                ant = i + ant;
                lstResultado.Items.Add("Número Anterior Somado (+) - Add: " + ant.ToString());
                lstResultado.Items.Add(" --------------- ");
            }
        }
    }
}
