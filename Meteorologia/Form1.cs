using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metreoligia;
using Newtonsoft.Json;

namespace Meteorologia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        /*Random r = new Random();
        private IDictionary<string, List<Meteorologia.Geral>> samples;
        JsonParser js = new JsonParser();
        JsonParser citiesparser = new JsonParser();
        Downloader dw = new Downloader();
        string caminho="";*/
        
        private async void Btn_chamada_Click(object sender, EventArgs e)
        {
            string link = "http://api.openweathermap.org/data/2.5/weather?id=2735943&appid=26d92f1c5f7e82d689c5f9e0e605735a&lang=pt";
            chart1.Series["Temperatura"].Points.Clear();
            var dados=await dw.Get(link, js);
            string dia;
            lbl_estado.Text = c.description.ToString();
            lbl_td.Text = c.main.ToString();
            /*if (cbb_cidades.Text!= "")
            {*/
                for (int i = 1; i < r.Next(1,50); i++)
                {
                    dia = "dia " + i;
                    this.chart1.Series["Temperatura"].Points.AddXY(dia, c.temp);
                }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            caminho = Path.GetFullPath("city.list.json(1)");
            MessageBox.Show(caminho);
            /*samples = JsonParser.Parsec(caminho);
            MessageBox.Show("FILE FOUND");
            for (int i = 0; i < samples.Count; i++)
            {
                cbb_cidades.Items.Add(cts.name.ToString());
            }*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
