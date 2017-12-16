using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StringReversal
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
        
            try
            {
                //Input dari 'txtInput.Text' window akan diletakkan di 'inptString' string

                string inptString = (txtInput.Text);

                // convert string dari ex : saya suka makan => ayas akus nakam ;

                string resultString = string.Join(" ", inptString       // resultString di cantum sini
                    .Split(' ')                                         // setiap string akan dijarakkan dengan satu space " "
                    .Select(x => new String(x.Reverse().ToArray())));   // x akan di-reverse kan dgn format setiap string dan .Select

                txtOutput.Text = resultString;                          // resultString akan masuk ke window 'txt.Output'                
            }
            catch (Exception upin)
            {
                MessageBox.Show(upin.Message);                           // exception catch ......
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";     // kosongkan input window bila klik 
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //Jumlah perkataan dgn tempat kosong

            lbTotal2.Text = txtInput.Text.Length.ToString();

            // Jumlah perkataan tanpa tempat kosong

            int total = txtInput.Text.Count(char.IsLetter);          
            lbTotal.Text = total.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtOutput.ReadOnly = true;                                  // Ouput window x boleh edit
            txtOutput.BackColor = System.Drawing.SystemColors.Window;   // Warna output window putih
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kita buat satu window untuk tanya user apabila depa klik button 'X', bila klik 'YES' program akan tutup

            DialogResult exitDialog = MessageBox.Show("Are you sure want to exit? ", "Exit", MessageBoxButtons.YesNo);
            if (exitDialog == DialogResult.Yes)
            {
                this.Dispose();                             // Dispose digunakan untuk release memory yang digunakan dari application ni
                Application.Exit();                         // Application tutup
            }
            
            // Bila klik 'NO' window exit akan tutup

            else if (exitDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
