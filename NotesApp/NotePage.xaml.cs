namespace NotesApp;

public partial class NotePage : ContentPage
{
    string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
    public NotePage()
	{
		InitializeComponent();
        if (File.Exists(fileName))
            TextoEditor.Text = File.ReadAllText(fileName);
    }

    private void SalvarButton_Clicked(object sender, EventArgs e)
    { 
        File.WriteAllText(fileName, TextoEditor.Text);
        DisplayAlert("Salvo com sucesso", "Mensagem salva", "Ok");
    }

    private void DeletarButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            DisplayAlert("Deletado com sucesso", "Mensagem deletada", "ok");
        }
            
        TextoEditor.Text = string.Empty;
        
    }
}