using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SprzedanePojazdyProgram
{
    public partial class Form1 : Form
    {
        private DataTable PojazdData;
        private Dictionary<string, int> sprzedazPojazdow;
        public Form1()
        {
            InitializeComponent();
            ScalWyniki();
        }

        //////////////////////////////////////////// ROZWIJANE MENU
   
        private void RozwijanieMenu()
        {
            if (this.panelMenu.Width > 200) //nierozwiniete
            {
                panelMenu.Width = 100;
                button_Menu.Visible = true;
                button_Menu.Width = 110;
                button_Menu.Height = 70;

                button_Menu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);

                }
            }
            else //rozwiniete
            {
                panelMenu.Width = 230;
                button_Menu.Visible = true;
                button_Menu.Width = 237;
                button_Menu.Height = 147;
                button_Menu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(20, 0, 0, 0);
                }
            }
        }
        private void button_Menu_Click(object sender, EventArgs e)
        {
            RozwijanieMenu();
        }

        ////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            chart.Visible = false;
            comboBox1.Visible = false;
            dataGridView1.Visible = false;
            label2.Visible = false;
        } // zaladowywanie items

        ////////////////////////////////////////////

        private void button_wczytaj_Click(object sender, EventArgs e) // PRZYCISK - wczytywanie pliku
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                PojazdData = ZaladujPojazdDataZPliku(filePath);

                // Pobranie unikalnych wartości województw
                List<string> wojewodztwa = PojazdData.AsEnumerable()
                    .Select(row => row.Field<string>("Wojewodztwo"))
                    .Distinct()
                    .ToList();

                // Wprowadzenie unikalnych wartości województw do ComboBox
                UzupelnienieComboBox(wojewodztwa);
                MessageBox.Show("Plik został wczytany pomyślnie.");
                comboBox1.Visible = true;
            }
        }

        private DataTable ZaladujPojazdDataZPliku(string filePath) // metoda zaladowywania plikow, datatable
        {
            DataTable dataTable = new DataTable();

            try
            {
                string[] linie = File.ReadAllLines(filePath);
                if (linie.Length > 0)
                {
                    // Ustawienie nagłówków kolumn
                    string[] naglowki = linie[0].Split(',');
                    foreach (string naglowek in naglowki)
                    {
                        dataTable.Columns.Add(naglowek);
                    }

                    // Dodanie danych
                    for (int i = 1; i < linie.Length; i++)
                    {
                        string[] data = linie[i].Split(',');
                        dataTable.Rows.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania pliku: " + ex.Message);
            }

            return dataTable;
        }

        private void button_generuj_Click(object sender, EventArgs e) // PRZYCISK - generuj wykresy i datagridview, odwolanie sie do scalwyniki
        {
            chart.Visible = true;

            if (PojazdData != null && PojazdData.Rows.Count > 0)
            {
                if (sprzedazPojazdow != null && sprzedazPojazdow.Count > 0)
                {
                    chart.Series.Clear();
                    chart1.Series.Clear();

                    Series series = new Series("Sprzedane auta");
                    series.ChartType = SeriesChartType.Column;

                    foreach (KeyValuePair<string, int> item in sprzedazPojazdow)
                    {
                        series.Points.AddXY(item.Key, item.Value);
                    }

                    

                    // WYKRES ZWYKLY
                    chart.Series.Add(series); 
                    chart.ChartAreas[0].AxisX.Interval = 1;
                    chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chart.Series["Sprzedane auta"].IsValueShownAsLabel = true;

                    // WYKRES OKRAGLY
                    
                    chart1.Series.Clear();
                    Series series1 = new Series("Sprzedane auta");
                    series1.ChartType = SeriesChartType.Pie;
                    foreach (KeyValuePair<string, int> item in sprzedazPojazdow)
                    {
                        series1.Points.AddXY(item.Key, item.Value);
                    }
                    chart1.Series.Add(series1);
                    chart1.Series["Sprzedane auta"].IsValueShownAsLabel = true;
                }
                else
                {
                    MessageBox.Show("Brak danych do wygenerowania wykresu. Wybierz województwo.");
                }
            }
            else
            {
                MessageBox.Show("Wczytaj plik z danymi przed wygenerowaniem wykresu.");
            }

            /// datagridview
            /// 
            dataGridView1.Visible = true;
            dataGridView1.DataSource = PojazdData;
            ScalWyniki();
        }

        private void button_zapisz_Click(object sender, EventArgs e) // PRZYCISK - zapisywanie
        {
            if (chart.Series.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pliki PNG (*.png)|*.png|Pliki JPEG (*.jpeg)|*.jpeg|Wszystkie pliki (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        chart.SaveImage(filePath, ChartImageFormat.Png);
                        MessageBox.Show("Wykres został zapisany pomyślnie.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd podczas zapisywania wykresu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak wygenerowanego wykresu do zapisu.");
            }
        }

        private Dictionary<string, int> ObliczanieSprzedanychPojazdow(DataTable data) // DICTIONARY, przechowywanie informacji kluczy, obliczanie sprzedanych pojazdow wedlug marki, metoda datatable
        {
            Dictionary<string, int> SprzedanePojazdy = new Dictionary<string, int>();

            try
            {
                string KolumnaMarka = "Marka auta";
                string KolumnaIlosc = "Ilosc sprzedanych aut";

                foreach (DataRow row in data.Rows)
                {
                    string marka = row[KolumnaMarka].ToString();
                    int soldCars = Convert.ToInt32(row[KolumnaIlosc]);

                    if (SprzedanePojazdy.ContainsKey(marka))
                    {
                        SprzedanePojazdy[marka] += soldCars;
                    }
                    else
                    {
                        SprzedanePojazdy[marka] = soldCars;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas obliczania sprzedanych aut: " + ex.Message);
            }

            return SprzedanePojazdy;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // COMBOBOX - wybieranie wojewodztwa
        {
            string WybraneWoj = comboBox1.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(WybraneWoj))
            {
                DataView filteredView = PojazdData.DefaultView;
                filteredView.RowFilter = $"Wojewodztwo = '{WybraneWoj}'";

                DataTable filteredData = filteredView.ToTable();
                sprzedazPojazdow = ObliczanieSprzedanychPojazdow(filteredData);

                if (sprzedazPojazdow.Count > 0)
                {
                    button_generuj.Enabled = true;
                }
                else
                {
                    button_generuj.Enabled = false;
                    MessageBox.Show("Brak danych dla wybranego województwa.");
                }
            }
            else
            {
                button_generuj.Enabled = false;
            }
        }

        private void UzupelnienieComboBox(List<string> provinces) // ad do COMBOBOX 
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(provinces.ToArray());
        }

        private void button_sumuj_Click(object sender, EventArgs e) // PRZYCISK - sumowanie i najwiecej pojazdow
        {
            string wojewodztwo = comboBox1.SelectedItem.ToString();

            // Znajdź wiersze odpowiadające wybranemu województwu
            DataRow[] wiersze = PojazdData.Select($"Wojewodztwo = '{wojewodztwo}'");

            // Sumuj liczbę sprzedanych aut dla danego województwa
            int suma = 0;
            foreach (DataRow wiersz in wiersze)
            {
                suma += Convert.ToInt32(wiersz["Ilosc sprzedanych aut"]);
            }

            // Wyświetl sumę na wykresie
            chart.Series["Sprzedane auta"].Points.Clear();
            chart.Series["Sprzedane auta"].Points.AddXY(wojewodztwo, suma);
            if (comboBox1.SelectedItem != null)
            {

                string wybraneWoj = comboBox1.SelectedItem.ToString();
                int sumaAut = SumujSprzedanePojazdy(wybraneWoj);
                label1.Visible = true;
                label1.Text = $"Suma sprzedanych pojazdów w województwie {wybraneWoj}: \n{sumaAut}";


                label2.Visible = true;
                if (wiersze.Length > 0)
                {
                    // Obliczanie sprzedanych pojazdów według marki w danym województwie
                    Dictionary<string, int> sprzedanePojazdy = ObliczanieSprzedanychPojazdow(wiersze.CopyToDataTable());

                    // Znalezienie marki, która występuje najczęściej
                    string najczestszaMarka = sprzedanePojazdy.OrderByDescending(x => x.Value).First().Key;

                    // Wyświetlenie sumy na wykresie
                    chart.Series["Sprzedane auta"].Points.Clear();
                    chart.Series["Sprzedane auta"].Points.AddXY(wybraneWoj, sprzedanePojazdy.Values.Sum());
                    chart.Series["Sprzedane auta"].IsValueShownAsLabel = true;

                    // Wyświetlenie najczęstszej marki w Label2
                    label2.Text = $"Najczęściej sprzedawana marka w województwie {wybraneWoj}: \n {najczestszaMarka}";
                }
                else
                {
                    MessageBox.Show("Brak danych dla wybranego województwa.");
                }
            }
            else
            {
                MessageBox.Show("Wybierz województwo przed sumowaniem.");
            }

            chart.Series["Sprzedane auta"].IsValueShownAsLabel = true;
        }

        private int SumujSprzedanePojazdy(string wojewodztwo) // metoda sumowania pojazdow
        {
            int sumaAut = 0;

            try
            {
                DataRow[] rows = PojazdData.Select($"Wojewodztwo = '{wojewodztwo}'");
                foreach (DataRow row in rows)
                {
                    int iloscSprzedanychAut = Convert.ToInt32(row["Ilosc sprzedanych aut"]);
                    sumaAut += iloscSprzedanychAut;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas sumowania sprzedanych aut: " + ex.Message);
            }

            return sumaAut;
        }

        private void button_wyjdz_Click(object sender, EventArgs e) // PRZYCISK - wyjscie
        {
            Application.Exit();
        }

        private void ScalWyniki() // metoda scalania wynikow
        {
            if (PojazdData != null && PojazdData.Rows.Count > 0 && comboBox1.SelectedItem != null)
            {
                string wybraneWojewodztwo = comboBox1.SelectedItem.ToString();

                DataView filteredView = PojazdData.DefaultView;
                filteredView.RowFilter = $"Wojewodztwo = '{wybraneWojewodztwo}'";

                DataTable filteredData = filteredView.ToTable();
                Dictionary<string, int> sprzedanePojazdy = ObliczanieSprzedanychPojazdow(filteredData);

                DataTable wyniki = new DataTable();
                wyniki.Columns.Add("Marka auta", typeof(string));
                wyniki.Columns.Add("Ilość sprzedanych aut", typeof(int));

                foreach (KeyValuePair<string, int> item in sprzedanePojazdy)
                {
                    wyniki.Rows.Add(item.Key, item.Value);
                }

                dataGridView1.DataSource = wyniki;
            }
        }

    }
}
