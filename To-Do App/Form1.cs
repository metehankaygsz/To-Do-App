namespace To_Do_App
{
    public partial class Form1 : Form
    {
        //Create list for text box to store
        List<TextBox> textboxlist = new List<TextBox>();
        //Char between two text boxes to specify them to separate
        char start = (char)2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add auto scroll
            AutoScroll=true;
            //Text load
            string contents = File.ReadAllText("text.txt");
            int i = 0;
            //Spilt text
            string[] spilt = contents.Split(start);
            foreach (var word in spilt)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                //Create new text box with old text
                createbox(word);
            }
        }

        private void createbox(string content)
        {
            //Specify text box properties
            TextBox textbox = new TextBox();
            textbox.Location = new(0, textboxlist.Count * 190 - 130);
            textbox.Multiline = true;
            textbox.Size = new Size(1011, 150);
            Controls.Add(textbox);
            textboxlist.Add(textbox);
            textbox.Text = content;

        }
        private void addtask_Click(object sender, EventArgs e)
        {
            //Create new text box using "createbox" func
            createbox("");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save text box content as text file
            File.WriteAllText("text.txt", String.Empty);
            //This "for" loop will count from 0 to textboxlist.Count (textboxlist.Count = number of open text boxes)
            for (int x = 0; x < textboxlist.Count; x++)
            {
                Console.WriteLine(textboxlist[x].Text);
                string loc = ("text.txt");
                using (StreamWriter sw = File.AppendText(loc))
                {
                    sw.WriteLine("" + start + textboxlist[x].Text);

                }
            }
        }
    }
}