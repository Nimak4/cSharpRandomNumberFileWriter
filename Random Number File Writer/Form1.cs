namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        int userInput, randomNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Setting up a streamwriter and a filter for the save file control to save as a txt file
            StreamWriter outputFile;
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // If "save" is chosen in the saveFile dialog box
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                int count = 0;
                // Urgh I stuck with a "numericupdown" over a regular text box since I enjoyed how it looked for this more
                // but it felt like such a headache compared to *just* taking integers with a text box haha
                // at least it looks good! :D
                userInput = Convert.ToInt32(Math.Round(numericInput.Value, 0));
                outputFile = File.CreateText(saveFile.FileName);
                
                // While count is less than the user's number
                while (count < userInput)
                {
                    var rand = new Random();
                    randomNumber = rand.Next(1, 101);
                    outputFile.WriteLine(randomNumber.ToString()); // Write a random number 1-100 then increment count
                    count++;
                }
                outputFile.Close();
            }

                
        }
    }
}
