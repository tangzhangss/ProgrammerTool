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
      
    }
}