using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] Links = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> levelCount = new Dictionary<string, int>();

            for (int i = 0; i < Links.Length; i++)
            {
                string path = Links[i];
                Uri URL;
                if (Uri.TryCreate(path, UriKind.Absolute, out URL) == false)
                {
                    MessageBox.Show($"Неверная ссылка {i}");
                    return;
                }
                if (URL.Scheme != "http" && URL.Scheme != "https" && URL.Scheme != "ftp")
                {
                    MessageBox.Show($"Неправильный протокол {i}");
                    return;
                }
                string host = URL.Host;
                if (host.EndsWith(".ru") || host.EndsWith(".rf"))
                {
                    string[] pathParts = URL.AbsolutePath.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    string rootFolder = pathParts.FirstOrDefault();
                    if (string.IsNullOrEmpty(rootFolder) == false)
                    {
                        int domainLevels = path.Split('.').Length - 1;
                        levelCount[host] = domainLevels;
                        path = path.Replace($"/{rootFolder}/", $"/myFolder{i + 1:000}/");
                        Links[i] = path;
                    }
                }
            }
            foreach (KeyValuePair<string, int> domainLevels in levelCount)
            {
                MessageBox.Show($"{domainLevels.Key}: {domainLevels.Value}");
            }
            textBox2.Text = string.Join(Environment.NewLine, Links);
        }
    }
}
    


