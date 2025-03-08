namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage() // não mexer
        {
            InitializeComponent();
        }



        private void OiButton_Clicked(object sender, EventArgs e)
        {
            //Pegar o nome que a pessoa digitou
            //Armazenar o nome em uma varíavel
            //Escrever o nome que está na varíavel em uma caixa de texto

            string nome = NomeEntry.Text;
            //NomeLabel.Text = "Oi, " + nome;
            NomeLabel.Text = $"Oi, {nome}";
        }
    }

}
