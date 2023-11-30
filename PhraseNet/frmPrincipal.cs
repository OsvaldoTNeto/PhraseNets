using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhraseNet
{
    public partial class frmPrincipal : Form
    {
        public string textoInformado = "";
        public List<string> stopWords = new List<string>() { "as", "os", "uns", "de", "com", "por", "a", "e", "o", "que", "um" };
        public List<string> escalaAzul = new List<string>() { "180068", "1E0080", "2900AF", "3100D1", "3C00FF"};

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnCarregarTexto_Click(object sender, EventArgs e)
        {
            this.ofd.Multiselect = false;
            this.ofd.Title = "Selecionar Texto";
            ofd.InitialDirectory = @"C:";
            ofd.Filter = "TXT files|*.txt";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;

            DialogResult dr = this.ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (ofd.FileNames.Count() > 0)
                {
                    textoInformado = File.ReadAllText(ofd.FileNames[0]);
                    this.rtbTexto.Text = textoInformado;

                    this.lblArquivo.Text = ofd.FileNames[0];
                    this.lblCaracter.Text = $"{textoInformado.Length}";
                    this.lblPalavras.Text = $"{textoInformado.Split(' ').Length}";
                }
            }
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPalavraChave.Text))
                MessageBox.Show("Palavra chave não informada", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                var ocorrencias = new List<ocorrenciaDTO>();
                var dadosPalavra = new List<dadosPalavraDTO>();

                var textoParaAnalise = textoInformado;
                var count = 0;
                
                if (cbNormalizarTexto.Checked)
                {
                    textoParaAnalise = textoParaAnalise.ToUpper();
                    textoParaAnalise = Regex.Replace(textoParaAnalise, "[^0-9a-zA-ZçÇãÃâÂáÁàÀéÉêÊèÈîÎíÍìÌõÕôÔóÓòÒúÚùÙÜü ]+", "").ToUpper(); 
                }

                var palavras = textoParaAnalise.Split(' ').ToList();
                palavras = palavras.Where(x => !string.IsNullOrEmpty(x.Trim()) && !string.IsNullOrWhiteSpace(x.Trim())).ToList();
                
                if (cbStopWords.Checked)
                {
                    if (this.cbNormalizarTexto.Checked)
                        palavras = palavras.Where(x => !stopWords.Select(y => y.ToUpper()).ToList().Contains(x)).ToList();
                    else
                        palavras = palavras.Where(x => !stopWords.Contains(x)).ToList();
                }

                var numeroDePalavrasParaAnalise = palavras.Count;
                var palavraChaveNormalizada = this.cbNormalizarTexto.Checked ? txtPalavraChave.Text.ToUpper() : txtPalavraChave.Text;
                
                palavras.ForEach(palavra =>
                {
                    if (palavra == palavraChaveNormalizada)
                    {
                        var palavraAnterior = count == 0 ? "" : palavras[count - 1];
                        var proximaPalavra = count == numeroDePalavrasParaAnalise - 1 ? "" : palavras[count + 1];

                        var ocorrenciaExistente = ocorrencias.FirstOrDefault(x => x.palavra1 == palavraAnterior && x.palavra2 == proximaPalavra);

                        if (ocorrenciaExistente != null)
                        {
                            ocorrencias.Remove(ocorrenciaExistente);
                            ocorrenciaExistente.count++;
                            ocorrencias.Add(ocorrenciaExistente);
                        }
                        else
                            ocorrencias.Add(new ocorrenciaDTO()
                            {
                                palavra1 = palavraAnterior,
                                palavra2 = proximaPalavra,
                                count = 1
                            });
                    }

                    count++;
                });

                var nuvemDepalavras = palavras.GroupBy(x => x);

                foreach (var item in nuvemDepalavras)
                {
                    var countPalavra1 = ocorrencias.Where(x => x.palavra1 == item.Key).Sum(x => x.count);
                    var countPalavra2 = ocorrencias.Where(x => x.palavra2 == item.Key).Sum(x => x.count);
                    dadosPalavra.Add(new dadosPalavraDTO()
                    {
                        palavra = item.Key,
                        count = item.Count(),
                        countP1 = countPalavra1,
                        countP2 = countPalavra2
                    });
                }

                this.dgvOcorrencias.Rows.Clear();
                this.dataGridView1.Rows.Clear();

                ocorrencias = ocorrencias.OrderByDescending(x => x.count).ToList();
                dadosPalavra = dadosPalavra.OrderByDescending(x => x.count).ToList();

                ocorrencias.ForEach(x =>
                {
                    this.dgvOcorrencias.Rows.Add(x.palavra1, x.palavra2, x.count);
                });

                dadosPalavra.ForEach(x =>
                {
                    this.dataGridView1.Rows.Add(x.palavra, x.count, x.countP1, x.countP2);
                });


                var valorMaximoDeOcorrencia = ocorrencias.Max(x => x.count);
                HttpClient client = new HttpClient();

                var graph = @"digraph G { ";
                ocorrencias.GetRange(0, 10).ToList().ForEach(x =>
                {
                    var dadoDaPalavra1 = dadosPalavra.FirstOrDefault(y => y.palavra == x.palavra1);
                    var dadoDaPalavra2 = dadosPalavra.FirstOrDefault(y => y.palavra == x.palavra2);

                    graph += $@" {x.palavra1} [shape=none,fontname=""times bold"",fontsize={CalculoTamanhoTexto(valorMaximoDeOcorrencia, x.count)},fontcolor=""#{CalculoCorTexto(dadoDaPalavra1.countP1, dadoDaPalavra1.countP2)}""];";
                    graph += $@" {x.palavra2} [shape=none,fontname=""times bold"",fontsize={CalculoTamanhoTexto(valorMaximoDeOcorrencia, x.count)},fontcolor=""#{CalculoCorTexto(dadoDaPalavra2.countP1, dadoDaPalavra2.countP2)}""];";
                    graph += $" {x.palavra1} -> {x.palavra2} [penwidth={CalculoEspessuraLinha(valorMaximoDeOcorrencia, x.count)}];";
                });
                graph += " }";

                var body = new
                {
                    graph = graph,
                    layout = "neato",
                    format = "png",
                };

                try
                {
                    var content = new StringContent(JsonConvert.SerializeObject(body));
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                    var response = client.PostAsync("https://quickchart.io/graphviz", content).Result;
                    var pngByteArray = response.Content.ReadAsByteArrayAsync().Result;
                    var memoryStream = new MemoryStream(pngByteArray);
                    var pngImage = Image.FromStream(memoryStream);
                    this.pictureBox1.Image = pngImage;
                }
                catch
                {
                    MessageBox.Show("Erro ao obter representação visual da API.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private int CalculoEspessuraLinha(int valorMaximo, int valor)
        {
            return (valor * 10 / valorMaximo) + 2;
        }

        private string CalculoCorTexto(int countP1, int countP2)
        {
            if(countP1>countP2)
                return escalaAzul[((countP1 * 5) / (countP1 + countP2))-1];
            else 
                return escalaAzul[((countP2 * 5) / (countP1 + countP2))-1];
        }

        private int CalculoTamanhoTexto(int valorMaximo, int valor)
        {
            return (valor * 20 / valorMaximo) + 5;
        }

        private void btnStopWords_Click(object sender, EventArgs e)
        {
            frmStopWord frmStopWord = new frmStopWord(stopWords);
            frmStopWord.ShowDialog();

            this.stopWords = frmStopWord.stopWords;
        }
    }

    public class RequisicaoJSON
    {
        public string graph { get; set; }
        public string layout { get; set; }
        public string format { get; set; }
    }
}
