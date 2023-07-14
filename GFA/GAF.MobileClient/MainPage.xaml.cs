//using Foundation;

namespace GAF.MobileClient
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            string name=string.Empty;
            int? age = null;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Shell.Current.DisplayAlert("Uyarı","Ad alanı boş bırakamaz","Tamam");
                return;

            }
            else
            {
                name=txtName.Text;

            }
            if (!string.IsNullOrEmpty(txtAge.Text))
               age=int.Parse(txtAge.Text);

            Shell.Current.DisplayAlert("Uyarı", "Ad alanı boş bırakamaz", "Tamam");
            //try
            //{
            //    count++;

            //    if (count == 1)
            //    {
            //        //if (sender is Label)
            //        //{
            //        //    lblCount.Text = count.ToString();

            //        //}
            //        //else if (sender is Button) {
            //        //    CounterBtn.Text = $"Clicked {count} time";
            //        //    txtHeader2.Text = "Abow";

            //        //}

            //    }
            //    else if (sender is Label)
            //    {
            //        lblCount.Text = count.ToString();

            //    }
            //    else if (sender is Button)
            //    {
            //        CounterBtn.Text = $"Clicked {count} time";
            //        txtHeader2.Text = "Abow";

            //    }

            //    else
            //    {

            //        CounterBtn.Text = $"Clicked {count} times";
            //    }

            //    SemanticScreenReader.Announce(CounterBtn.Text);
            //}
            //catch (Exception)
            //{

            //    Shell.Current.DisplayAlert("Hata", "Hata oluştu", "Tamam", "İptal");
            //}

        }
    }
}