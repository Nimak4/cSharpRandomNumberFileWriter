namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        
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
            // Declaring variables in just the click event now!
            int userInput, randomNumber;

            // Declaring constants instead of just putting 1 and 101 in my rand.next
            const int rangeStart = 1;
            const int rangeEnd = 101;
            // Setting up the random object outside of the loop!
            var rand = new Random();
            randomNumber = rand.Next(rangeStart, rangeEnd);

            // Try-catch for any file writing errors!
            try
            {
                // Reading userInput here in order to do an if-else to make sure the user enters a number higher than zero!
                userInput = Convert.ToInt32(Math.Round(numericInput.Value, 0));
                if (userInput > 0)
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
                        outputFile = File.CreateText(saveFile.FileName);

                        // While count is less than the user's number
                        while (count < userInput)
                        {
                            outputFile.WriteLine(randomNumber.ToString()); // Write a random number 1-100 then increment count
                            count++;
                        }
                        outputFile.Close();
                        MessageBox.Show("File saved!");
                    }
                    // If user says "cancel" on file saving
                    else
                    {
                        MessageBox.Show("File saving cancelled!");
                    }
                }
                // If the user enters 0!
                else
                {
                    MessageBox.Show("Please input a value greater than zero. (Remember, numbers get rounded!)");
                }
            }
            // In case there are errors writing files!
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
