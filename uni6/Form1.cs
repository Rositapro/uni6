using System.Diagnostics;
namespace uni6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureListView();
            AttachKeyPressEvents();
        }

        private void ConfigureListView()
        {
            lsvContent.View = View.Details;
            lsvContent.Columns.Add("Name", 100);
            lsvContent.Columns.Add("Spanish", 100);
            lsvContent.Columns.Add("Mathematics", 100);
            lsvContent.Columns.Add("English", 100);
            lsvContent.Columns.Add("Science", 50);
            lsvContent.Columns.Add("Physics", 100);
            lsvContent.Columns.Add("Avarage", 100);
        }
        private void AttachKeyPressEvents()
        {
            txtName.KeyPress += TextBox_KeyPress;
            txtSpanish.KeyPress += NumericTextBox_KeyPress;
            txtMathematics.KeyPress += NumericTextBox_KeyPress;
            txtEnglish.KeyPress += NumericTextBox_KeyPress;
            txtScience.KeyPress += NumericTextBox_KeyPress;
            txtPhysics.KeyPress += NumericTextBox_KeyPress;
        }
        //Metodo que recibe parametros pero no regresa nada
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

                if (char.IsDigit(e.KeyChar))
                {
                    string currentText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());
                    if (double.TryParse(currentText, out double value))
                    {
                        if (value > 10)
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtSpanish.Clear();
            txtMathematics.Clear();
            txtEnglish.Clear();
            txtScience.Clear();
            txtPhysics.Clear();
            txtAvarage.Clear();

        }
        private void ibtnSave_Click(object sender, EventArgs e)
        {

            string[] datos = new string[7];
            datos[0] = txtName.Text;
            datos[1] = txtSpanish.Text;
            datos[2] = txtMathematics.Text;
            datos[3] = txtEnglish.Text;
            datos[4] = txtScience.Text;
            datos[5] = txtPhysics.Text;
            datos[6] = txtAvarage.Text;

            ListViewItem item = new ListViewItem(datos[0]);
            for (int i = 1; i < datos.Length; i++)
            {
                item.SubItems.Add(datos[i]);
            }

            lsvContent.Items.Add(item);
            ClearTextBoxes();
        }

        private void ibtnCalculateAvarage_Click(object sender, EventArgs e)
        {
            try
            {
                double spanish = double.Parse(txtSpanish.Text);
                double mathematics = double.Parse(txtMathematics.Text);
                double english = double.Parse(txtEnglish.Text);
                double science = double.Parse(txtScience.Text);
                double physics = double.Parse(txtPhysics.Text);

                double average = (spanish + mathematics + english + science + physics) / 5;
                txtAvarage.Text = average.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid ratings in all fields..", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibtnSaveTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Texto|*.txt";

            string filePath = string.Empty;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    foreach (ColumnHeader column in lsvContent.Columns)
                    {
                        writer.Write(column.Text);
                        writer.Write(", ");
                    }
                    writer.WriteLine();

                    foreach (ListViewItem item in lsvContent.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            writer.Write(item.SubItems[i].Text);
                            if (i < item.SubItems.Count - 1)
                            {
                                writer.Write(", ");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Data successfully saved to TXT file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
        }
    }
}
