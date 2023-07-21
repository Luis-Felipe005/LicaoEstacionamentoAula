namespace LicaoEstacionamento
{
    public partial class Form1 : Form 
    {
       List<String>ListaEstacionamento = new List<String>();
        List<int>ListaDePlacas = new List<int>();   
       
        
        public Form1()
        {
            InitializeComponent();




        }

        void ListaDeCarros()
        {


            

         





            string carro = textBox1.Text;
            
            ListaEstacionamento.Add(carro);
            ListaEstacionamento.Remove(carro);
           


        }

        void atualizarInterface ()
        {

            int ListaDePlacas = ListaEstacionamento.Count();
            lblNumero.Text = ListaDePlacas.ToString();



        }

        void AcrescentarNaLista()
        {
           

       
            string placa = textBox1.Text;

            ListaEstacionamento.Add(placa);

            for (int i = 0; i <  ListaEstacionamento.Count; i++)
            {

                listView1.Items.Add($"VAGA {i}] - {ListaEstacionamento}");

            }




        }

        void VerificarEstacionamento()
        {
            //Verifica se está cheio oestacionamento

            if (ListaEstacionamento.Count >= 5)
            {

                MessageBox.Show("Tá lotado cara!");
                return;
            }

            // Verifica se a pessoa digitou algo

            if (textBox1.Text == "")
            {

                MessageBox.Show("Preencha o campo para continuar");
                return;
            }



        }

       
 

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDeCarros();
            atualizarInterface();
            AcrescentarNaLista();
            VerificarEstacionamento();





        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {

            ListView.Remove();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}