namespace Promedio;
///<Summary>
///<Createddate>23/06/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>23/06/2023</lastmodificationdate>
///<lastmodificationdescription>
///Mostrar el resultado en un label y no en un entry
///</lastmodificationdescription>
///<lastmodifierautor>Erika chávez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
    /// <summary>
	/// constructor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
    /// <summary>
    /// calcular el promedio de 5 notas y mandar un resultado
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void Resultdo_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(nota1.Text) || !string.IsNullOrEmpty(nota2.Text) ||
            !string.IsNullOrEmpty(nota3.Text) || !string.IsNullOrEmpty(nota4.Text) || !string.IsNullOrEmpty(nota5.Text))
        {
            int N1, N2, N3, N4, N5, Resul;

            N1 = Convert.ToInt32(nota1.Text);
            N2 = Convert.ToInt32(nota2.Text);
            N3 = Convert.ToInt32(nota3.Text);
            N4 = Convert.ToInt32(nota4.Text);
            N5 = Convert.ToInt32(nota5.Text);

            Resul = (N1 + N2 + N3 + N4 + N5) / 5;

            promedio.Text = Resul.ToString();
        }
    }
}

