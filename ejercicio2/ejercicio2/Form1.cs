namespace ejercicio2
{
    public partial class arreglo : Form
    {
        public arreglo()
        {
            InitializeComponent();
        }

        private void guardarbutton2_Click(object sender, EventArgs e)
        {
            string[] arreglo={"nombre y edad:", nombretextBox1.Text }; 

            int[] arreglo1={   Convert.ToInt32(edadtextBox2.Text ) };




            foreach (string item in arreglo)
            {
                listBox1.Items.Add(item);


            }

            //listBox1.Items.Add(arreglo1  ); 

            foreach (int  item in arreglo1)
            {
                listBox1.Items.Add( item);
            }

nombretextBox1.Clear(); 
            edadtextBox2.Clear();


        }

       
    }
}


                