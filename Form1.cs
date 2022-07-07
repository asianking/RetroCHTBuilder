using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace RetroCHTBuilder
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

            //Working directories:
            string GetRightFolder = System.IO.Directory.GetCurrentDirectory();
            Global.WorkingDirectory = GetRightFolder + @"\" + CBPlatform.Text + @"\";

            //check directory
            //MessageBox.Show(Global.WorkingDirectory);

            if (Directory.Exists(Global.WorkingDirectory))
            {
                InputBrowse.Text = Global.WorkingDirectory;
            } else
            {
                //Directory.CreateDirectory(Global.WorkingDirectory);
                Global.WorkingDirectory = GetRightFolder;
                InputBrowse.Text = GetRightFolder;
                
            }

            
        }





        static class Global
        {
            public static string WorkingDirectory;
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            BEAdd.Enabled = false;

        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            BEAdd.Enabled = true;

        }

        void changeLine(RichTextBox RTB, int line, string text)
        {
            int s1 = RTB.GetFirstCharIndexFromLine(line);
            int s2 = line < RTB.Lines.Count() - 1 ?
                      RTB.GetFirstCharIndexFromLine(line + 1) - 1 :
                      RTB.Text.Length;
            RTB.Select(s1, s2 - s1);
            RTB.SelectedText = text;
        }

        private void BEAdd_Click(object sender, EventArgs e)
        {

            bool checkme = false;

            if (CBEnable.Checked)
            {
                checkme = true;
            }

            //write new lines
            //MessageBox.Show(InputFile.Find("Cheats =").ToString()); >> -1 means does not exist | 0 means it exist
            if (InputFile.Find("Cheats =") != 0)
            {
                //Start refresh code
                //MessageBox.Show("Cheats Does Not Exist!");

                //replace newline & whitespaces with +
                string getcodes = InputCode.Text;
                getcodes = getcodes.Replace(Environment.NewLine, "+");
                getcodes = getcodes.Replace(" ", "+");


                changeLine(InputFile, 0, "Cheats = 1\r\n\r\ncheat0_desc = \"" + input_Desc.Text + "\"\r\ncheat0_code = \"" + getcodes + "\"\r\ncheat0_enable = " + checkme + "\r\n\r\n");
            }
            else
            {
                //Append to existing codes
                //MessageBox.Show("Cheats Exist!");

                //Use it if code exist
                //get last line of the textbox
                int totalLines = InputFile.Lines.Length;
                string stringlastline = InputFile.Lines[totalLines - 1];
                int lastline = InputFile.GetLineFromCharIndex(InputFile.Find(stringlastline));

                //find the line that contains cheats = x
                int getcheatsline = InputFile.GetLineFromCharIndex(InputFile.Find("Cheats ="));
                //MessageBox.Show(getcheatsline.ToString());

                //check how many cheats are available
                String GetNumber = InputFile.Lines[getcheatsline];
                var theNumber = Regex.Match(GetNumber, @"\d+").Value;
                int currentNumber = Convert.ToInt32(theNumber);
                int newNumber = Convert.ToInt32(theNumber);
                newNumber += 1;
                //MessageBox.Show(newNumber.ToString());

                //append new cheats number
                changeLine(InputFile, getcheatsline, "Cheats = " + newNumber.ToString());

                //replace newline & whitespaces with +
                string getcodes = InputCode.Text;
                getcodes = getcodes.Replace(Environment.NewLine, "+");
                getcodes = getcodes.Replace(" ", "+");

                //apend new codes
                string newcodes = "cheat" + currentNumber + "_desc = \"" + input_Desc.Text + "\"\r\ncheat" + currentNumber + "_code = \"" + getcodes + "\"\r\ncheat" + currentNumber + "_enable = " + checkme + "\r\n\r\n";
                InputFile.AppendText(newcodes);


            }




            //clear boxes after add
            InputCode.Text = "";
            input_Desc.Text = "";
            input_Desc.Select();

        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            //Uncomment to check and see if directory is correct. 
           // MessageBox.Show(Global.WorkingDirectory);

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Global.WorkingDirectory;
            openFileDialog1.Filter = "Text files (*.cht)|*.cht|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //...
                InputBrowse.Text = selectedFileName;
            }
        }

        private void BLoad_Click(object sender, EventArgs e)
        {

            if (!InputBrowse.Text.Contains(".cht"))
            {
                LStatus.Text = "NOTE: No File found. Please check file name on Browser Field!";
                LStatus.ForeColor = Color.Red;

            } else {

                if (File.Exists(InputBrowse.Text))
                {

                    BOSave.Enabled = false;
                    InputFile.Text = File.ReadAllText(InputBrowse.Text);
                    LStatus.ForeColor = Color.Green;
                    LStatus.Text = "NOTE: Cheat Load Successfully.";
                }
                else
                {
                    LStatus.Text = InputBrowse.Text + "\r\n -- Does not exist! Please check.";
                    LStatus.ForeColor = Color.Red;
                }
            }
        
            
        }

        private void BOSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputFile.Text))
            {
                LStatus.Text = "NOTE: Please make sure there is data on the Rich Text field!";
                LStatus.ForeColor = Color.Red;
            }
            else
            {
                if (!InputBrowse.Text.Contains(".cht"))
                {
                    //if the browser input does not have the .cht string on; use the Name field to fulfill the full request.
                    //check to see if the cht exist on the folder
                    if (File.Exists(InputBrowse.Text + InputGN.Text + ".cht"))
                    {
                        BOSave.Enabled = true;
                        InputFile.SaveFile(InputBrowse.Text + InputGN.Text + ".cht", RichTextBoxStreamType.PlainText);
                        LStatus.Text = "NOTE: File Exist. Updated!";
                        LStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        BOSave.Enabled = true;
                        InputFile.SaveFile(InputBrowse.Text + InputGN.Text + ".cht", RichTextBoxStreamType.PlainText);
                        LStatus.Text = "NOTE: New Cheats has been saved!";
                        LStatus.ForeColor = Color.Green;
                    }
                }
                else
                {
                    //check to see if the cht exist on the folder
                    if (File.Exists(InputBrowse.Text))
                    {
                        BOSave.Enabled = true;
                        InputFile.SaveFile(InputBrowse.Text, RichTextBoxStreamType.PlainText);
                        LStatus.Text = "NOTE: Update Completed!";
                        LStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        BOSave.Enabled = true;
                        InputFile.SaveFile(InputBrowse.Text, RichTextBoxStreamType.PlainText);
                        LStatus.Text = "NOTE: New Cheats has been saved!";
                        LStatus.ForeColor = Color.Green;
                    }
                }
            }



        }

        private void CBPlatform_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Working directories:
            string GetRightFolder = System.IO.Directory.GetCurrentDirectory();
            Global.WorkingDirectory = GetRightFolder + @"\" + CBPlatform.Text + @"\";

            //check directory
            //MessageBox.Show(Global.WorkingDirectory);

            if (Directory.Exists(Global.WorkingDirectory))
            {
                InputBrowse.Text = Global.WorkingDirectory;
            }
            else
            {
                //Directory.CreateDirectory(Global.WorkingDirectory);
                Global.WorkingDirectory = GetRightFolder;
                InputBrowse.Text = GetRightFolder;

            }
        }
    }
}
