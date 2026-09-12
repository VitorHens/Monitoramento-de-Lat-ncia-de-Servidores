 /* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 28/05/2026
 * Autores do Projeto: FELIPE GAMEZ SANCHES
 *                     VITOR HENS FERNANDES ANDRADE
 * Turma: 2F
 * Projeto
 * Observação: <colocar se houver>
 * 
 * ProjetoPVB02.cs
 * ************************************************************/  

using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace ProjetoPVB02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

			int totalLinhas = dados.LineCount;
            double soma = 0;
            double maior = 0;
            double menor = 0;

			for (int i = 0; i < totalLinhas; i++)
			{
				string textoDaLinha=dados.GetLineText(i);
                double n=double.Parse(textoDaLinha);

                soma+=n;

                if (i==0) {

                    maior = n;
                    menor = n;

                } else {

                    if (maior < n)
                        maior = n;

                    if (menor > n)
                        menor = n;

                }

			}

            double media = soma / totalLinhas;
            double somaD = 0;

            for (int i = 0; i < totalLinhas; i++)
            {
				string textoDaLinha = dados.GetLineText(i);
				double n = double.Parse(textoDaLinha);

                double des = (n - media) * (n - media);
                somaD += des;

		    }

            double totalV = somaD / (totalLinhas - 1);

            double totalD = Math.Sqrt(totalV);

            qtd.Content = "Quantidade de elementos: " + totalLinhas.ToString("0");
            min.Content = "Valor Mínimo: " + menor.ToString("0.00");
            max.Content = "Valor Máximo: " + maior.ToString("0.00");
            med.Content = "Média Aritmética: " + media.ToString("0.00");
            var.Content = "Variância Amostral: " + totalV.ToString("0.00");
            des.Content = "Desvio Padrão Amostral: " + totalD.ToString("0.00");

		}

 
	}
}