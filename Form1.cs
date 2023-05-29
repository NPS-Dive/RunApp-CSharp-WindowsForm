namespace WinFormsApp_36_Run
    {
    public partial class Form1 : Form
        {
        public Form1 ()
            {
            InitializeComponent();
            }

        private void BTNrun_Click ( object sender, EventArgs e )
            {
            try
                {
                System.Diagnostics.Process.Start(textBox1.Text);
                }
            catch (Exception ex)
                {
                MessageBox.Show("such program Not found!");
                }
            }

        /* private void textBox1_KeyPress ( object sender, KeyPressEventArgs e )
             {
             try
                 {
                 if (e.KeyChar == (char)13)
                     {
                     System.Diagnostics.Process.Start(textBox1.Text);
                     }
                 }
             catch (Exception ex)
                 {

                 }
             }     */

        private void textBox1_KeyDown ( object sender, KeyEventArgs e )
            {
            try
                {
                if (e.KeyCode == Keys.Enter)
                    {
                    System.Diagnostics.Process.Start(textBox1.Text);
                    }
                }
            catch (Exception ex)
                {

                }
            }

        private void BTNbrowse_Click ( object sender, EventArgs e )
            {
            try
                {
                OpenFileDialog openFileDialogBrowse = new OpenFileDialog();
                if (openFileDialogBrowse.ShowDialog() == DialogResult.OK)
                    {
                    textBox1.Text = openFileDialogBrowse.FileName;
                    System.Diagnostics.Process.Start(textBox1.Text);
                    }
                }
            catch
                {

                }
            }

        private void BTNhelp_Click ( object sender, EventArgs e )
            {
            //MessageBox.Show(Application.StartupPath);
            try
                {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\help.pdf");
                }
            catch
                {
                
                MessageBox.Show("You shall install Acrobat reader first!, please click ok to proceed!", "Adobe Acrobat Reader is Needed!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                System.Diagnostics.Process.Start(Application.StartupPath + "\\readerdc64_en_ha_mdr_install.exe");
                }

            }
        }
    }