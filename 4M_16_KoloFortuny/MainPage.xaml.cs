namespace _4M_16_KoloFortuny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int countP = 0;
        int countN = 0;
        string slowo = "SAMOCHÓD";
        char[] z = "--------".ToCharArray();
        //char[] z = { '-', '-', '-', '-', '-', '-', '-', '-' };

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLitera(object sender, EventArgs e)
        {
            if (lblZgadnij.Text.Length == 0) return;
            bool czyZgadnieta = false;
            char znak = entLitera.Text.ToUpper()[0];
            for(int i = 0; i<slowo.Length; i++)
            {
                if (slowo[i] == znak)
                {
                    z[i] = znak;
                    czyZgadnieta = true;
                }                  
            }
            string s = new string(z);
            lblZgadnij.Text = s;
            count++;
            if (czyZgadnieta)
                countP++;
            else
                countN++;
            lblProb.Text = $"Prób {count}";
            lblProbP.Text = $"Prób {countP}";
            lblProbN.Text = $"Prób {countN}";
        }
    }
}