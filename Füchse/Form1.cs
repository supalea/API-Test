using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Füchse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFuchs_Click(object sender, EventArgs e)
        {
            await LoadFox();
        }


        private async Task Duck()
        {
            string apiUrl = "https://random-d.uk/api/v2/quack";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    string imageUrl = json["url"].ToString();
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    pictureBox1.Load(imageUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden des Enten-Bildes: {ex.Message}");
                }
            }
        }
        private async Task LoadFox()
        {
            string apiUrl = "https://randomfox.ca/floof/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    string imageUrl = json["image"].ToString();
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    pictureBox1.Load(imageUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden des Fuchs-Bildes: {ex.Message}");
                }
            }
        }

        private async void btnEnte_Click(object sender, EventArgs e)
        {
            await Duck();
        }
    }
}
