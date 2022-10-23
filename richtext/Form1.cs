using System.Windows.Forms.VisualStyles;

namespace richtext
{
    public partial class Form1 : Form
    {   private Font font;
        public Form1()
        {
            InitializeComponent();
        }      

        private void scrivi_Click(object sender, EventArgs e)
        {
            FontStyle f;
            //riferimento al testo selezionato
            font = richTextBox1.SelectionFont;
            if (font != null)
            {
                f = font.Style;
                //controllo stili selezionati
                if (grassetto.Checked)
                    f ^= FontStyle.Bold;
                if (corsivo.Checked)
                    f ^= FontStyle.Italic;
                if (sottolineato.Checked)
                    f ^= FontStyle.Underline;
                //setta lo stile del font
                richTextBox1.SelectionFont = new Font(font, f);
            }
            //setta il colore
            richTextBox1.SelectionColor = colorDialog1.Color;
            //aggiunge il testo applicando stile e colore
            richTextBox1.AppendText(textBox1.Text+"\n");
        }

        private void scelta_colore_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void corsivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}