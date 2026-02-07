namespace Quotes_App
{
    public partial class Form1 : Form
    {
        List<string> quotes = new List<string>
        {
            "Do what you can, with what you have, where you are.",
            "Small steps every day lead to big changes.",
            "Success is built on the courage to begin.",
            "Your future is created by what you do today.",
            "Discipline is choosing what you want most over what you want now.",
            "Growth starts at the edge of your comfort zone.",
            "Dreams work when you work for them.",
            "Fall seven times, stand up eight.",
            "Consistency beats intensity.",
            "The quiet mind hears opportunity first."
        };

        List<int> usedIndex = new List<int>();

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            if (usedIndex.Count == quotes.Count)
            {
                usedIndex.Clear();
            }

            int index;

            do
            {
                index = random.Next(0, quotes.Count);
            } while (usedIndex.Contains(index));

            TextLbl.Text = quotes[index];

            usedIndex.Add(index);
        }
    }
}
