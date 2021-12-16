using System.Text;
using Newtonsoft.Json;

namespace ProgrammerTool
{
    public partial class MyContainer : Form
    {
        public MyContainer()
        {
            InitializeComponent();
        }

        private void JSONBtn_Click(object sender, EventArgs e)
        {
            var text = StringTextBox.Text;
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(text);
            JsonTextReader jtr = new JsonTextReader(tr);
            try
            {
                object obj = serializer.Deserialize(jtr);
                if(obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    StringTextBox.Text = textWriter.ToString();
                }
               
            }catch (Exception ex)
            {
                MessageBox.Show("转换失败，请检查格式!");
            }
        }

        private void SQLBtn_Click(object sender, EventArgs e)
        {
            var text = StringTextBox.Text;
            var formattedSQL = NSQLFormatter.Formatter.Format(text);
            formattedSQL = formattedSQL.Replace("\n", "\r\n");//window \r\n才是换行
            StringTextBox.Text= formattedSQL;
        }

        private void UnicodeBtn_Click(object sender, EventArgs e)
        {
            String text = StringTextBox.Text;
            String temp;
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                temp = ((int)text[i]).ToString("x");
                if (temp.Length<4)
                {
                    temp = "00" + temp;
                }
                res.Append("\\u").Append(temp);
            }
            StringTextBox.Text = res.ToString();
        }

        private void UnicodeBtn2_Click(object sender, EventArgs e)
        {
            String text = StringTextBox.Text;
            String[] strList = text.Split("\\u");
            StringBuilder res = new StringBuilder();
            char temp;
            for (int i = 1; i < strList.Length; i++)
            {
                temp = (char)int.Parse(strList[i], System.Globalization.NumberStyles.HexNumber);
                res.Append(temp);
            }
            StringTextBox.Text = res.ToString();
        }
    }
}