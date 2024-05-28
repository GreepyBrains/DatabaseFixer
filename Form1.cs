using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DatabaseFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _databaseQuery = textBox1.Text;

            if (ReplaceCheckBox.Checked)
                _databaseQuery = _databaseQuery.Replace("or replace", "", true, CultureInfo.InvariantCulture);

            if (ToPlusCheckBox.Checked)
                _databaseQuery = _databaseQuery.Replace("||", "+", true, CultureInfo.InvariantCulture);

            if (XTimeCheckBox.Checked)
                _databaseQuery = _databaseQuery.Replace("XTIME", "gfostest", true, CultureInfo.InvariantCulture);


            //Deletion of Group By
            string[] _queryLines = _databaseQuery.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            _databaseQuery = "";
            for (int i = 0; i < _queryLines.Length; i++)
            {
                if ((_queryLines[i].ToLower().Contains("group by") && GroupByCheckBox.Checked) || (_queryLines[i].ToLower().Contains("order by") && OrderByCheckBox.Checked))
                    _queryLines[i] = "";

                if (ToDateRegexCheckBox.Checked)
                {
                    if (_queryLines[i].ToLower().Contains("to_date"))
                    {
                        string _pattern = @"(?i)TO_DATE\(.*?[)]";
                        Regex _regex = new Regex(_pattern);
                        _queryLines[i] = _regex.Replace(_queryLines[i], "CAST('01.01.1600' AS DATETIME)");
                    }
                }

                _databaseQuery += _queryLines[i];
                _databaseQuery += Environment.NewLine;
            }
            textBox2.Text = _databaseQuery;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}