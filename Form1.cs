using System.Diagnostics;
using System.Globalization;

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

            _databaseQuery = _databaseQuery.Replace("or replace", "", true, CultureInfo.InvariantCulture);
            _databaseQuery = _databaseQuery.Replace("||", "+", true, CultureInfo.InvariantCulture);
            _databaseQuery = _databaseQuery.Replace("XTIME", "gfostest", true, CultureInfo.InvariantCulture);

            //Deletion of Group By
            string[] _queryLines = _databaseQuery.Split(new string[] { Environment.NewLine}, StringSplitOptions.None);
            _databaseQuery = "";
            for (int i = 0; i < _queryLines.Length; i++)
            {
                if (_queryLines[i].ToLower().Contains("group by") || _queryLines[i].ToLower().Contains("order by"))
                    _queryLines[i] = "";

                Debug.WriteLine(i);
                _databaseQuery += _queryLines[i];
                _databaseQuery += Environment.NewLine;
            }
            textBox2.Text = _databaseQuery;
        }
    }
}
