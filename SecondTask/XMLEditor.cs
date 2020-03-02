using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SecondTask
{
    public partial class XMLEditor : Form
    {
        File xmlFile;
        PatternFileName pattern = new PatternFileName(@"^[а-я]{1,100}_(\d{1}|\d{10}|\d{14,20})_.{1,7}\.xml$");
        XMLData xmlData;
        public XMLEditor()
        {
            InitializeComponent();
            ChooseFileButton.Click += ChooseFileButton_Click;
            SaveChangesButton.Click += SaveChangesButton_Click;
            SetDataEnable.Click += SetDataEnable_Click;
            DisplayDataButton.Click += DisplayDataButton_Click;
        }

        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            SetDataFromXml(xmlData);
        }

        private void SetDataEnable_Click(object sender, EventArgs e)
        {
            FileVersionTextBox.Enabled = true;
            FileNameTextBox.Enabled = true;
            ChangeFileDate.Enabled = true;
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            xmlFile = new File(openFileDialog.SafeFileName, openFileDialog.FileName);
            if (xmlFile.IsValid(pattern))
            {
                SafeFileNameTextBox.Text = xmlFile.SafeFileName;
                xmlData = new XMLData(xmlFile.FileName);
            } else
                MessageBox.Show($"Имя файла {xmlFile.SafeFileName} не соответствует требуемому формату");
        }

        public void SetDataFromXml(XMLData xml)
        {
            if (xml != null)
            {
                FileVersionTextBox.Text = xml.GetAttributForName("FileVersion").Value;
                FileNameTextBox.Text = xml.GetElementForName("Name").Value;
                ChangeFileDate.Text = xml.GetElementForName("DateTime").Value;
            }
        }

        public void SaveChangesButton_Click(object sender, EventArgs e)
        {
            {
                xmlData.SetValueAttributForName("FileVersion", FileVersionTextBox.Text);
                xmlData.SetValueElementForName("Name", FileNameTextBox.Text);
                xmlData.SetValueElementForName("DateTime", ChangeFileDate.Text);
            }

            xmlData.SaveXmlDocument();
            MessageBox.Show("Изменения успешно сохранены");
        }
    }
}

