namespace SudokuApp
{
    using static SudokuApp.SudokuUtils;

    public partial class Sudoku : Form
    {
        private int countdownSeconds = 0; // Initial countdown value in seconds

        Cells[,] cells = new Cells[9, 9]; // Initialize 2D-Array 9x9

        public Sudoku()
        {
            InitializeComponent();
            createCells(this.panel2, cells); // Creates the 9x9 grid
            timer1.Interval = 1000; // timer countdown interval in miliseconds
        }

        //Creating New Game
        private void startNewGame()
        {
            loadValues();
            this.panel2.Enabled = true;
            this.clearButton.Enabled = true;
            this.checkButton.Enabled = true;
            this.solutionButton.Enabled = true;

            var hintsCount = 0;

            // Assign the hints count based on the level player chosen
            if (easyLevel.Checked)
                hintsCount = 45;
            else if (mediumLevel.Checked)
                hintsCount = 30;
            else if (hardLevel.Checked)
                hintsCount = 15;
            else if (testLevel.Checked)
                hintsCount = 80;

            showRandomValuesHints(hintsCount);

        }

        //Fills the 9x9 grid with correct values
        private void loadValues()
        {
            // Clear the values in each cells
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.IsLocked = false;
                cell.Clear();
            }

            // This method will be called recursively until it finds suitable values for each cells
            findValueForNextCell(0, -1);
        }

        //Generates values for each cell
        private bool findValueForNextCell(int i, int j)
        {
            // Increment the i and j values to move to the next cell and if the columns ends move to the next row
            if (++j > 8)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Random random = new Random();

            // Find a random and valid number for the cell and go to the next cell and check if it can be allocated with another random and valid number
            do
            {
                // If there is not numbers left in the list to try next, return to the previous cell and allocate it with a different number
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Take a random number from the numbers left in the list
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Remove the allocated value from the list
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));


            return true;
        }

        //Check if number meets all the rules
        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        //Display random cells to the player.
        private void showRandomValuesHints(int hintsCount)
        {
            // Define a list to hold all possible coordinates
            List<Point> allCoordinates = new List<Point>();

            // Fill the list with all possible coordinates
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    allCoordinates.Add(new Point(x, y));
                }
            }


            // Shuffle the list of coordinates
            Shuffle(allCoordinates);

            // Assign unique coordinates to cells
            for (int i = 0; i < hintsCount; i++)
            {
                Point coordinate = allCoordinates[i];
                cells[coordinate.X, coordinate.Y].Text = cells[coordinate.X, coordinate.Y].Value.ToString();
                cells[coordinate.X, coordinate.Y].ForeColor = Color.Black;
                cells[coordinate.X, coordinate.Y].IsLocked = true;
            }
        }

        // Shows solution
        private void showSolution()
        {
            // Load the solution into the cells
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!cells[i, j].Text.Equals(cells[i, j].Value.ToString()))
                    {
                        cells[i, j].ForeColor = Color.Blue;
                    }
                    cells[i, j].Text = cells[i, j].Value.ToString();
                    cells[i, j].IsLocked = true;
                    this.clearButton.Enabled = false;
                    this.checkButton.Enabled = false;
                }
            }
        }

        //Button to check if the input is valid
        private void checkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<Cells>();

            // Find all the wrong inputs
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // Check if the inputs are wrong or the player wins 
            if (wrongCells.Any())
            {
                // Highlight the wrong inputs 
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong Inputs");
            }
            else
            {
                this.panel2.Enabled = false;
                this.clearButton.Enabled = false;

                timer1.Stop();
                MessageBox.Show("You Win");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                // Clear the cell only if it is not locked
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (easyLevel.Checked)
                countdownSeconds = 600;
            else if (mediumLevel.Checked)
                countdownSeconds = 300;
            else if (hardLevel.Checked)
                countdownSeconds = 150;
            else if (testLevel.Checked)
                countdownSeconds = 10;

            label1.Text = $"Countdown: {countdownSeconds} seconds"; // Update label text
            timer1.Start();
            startNewGame();

        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            showSolution();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var cell = sender as Cells;

            if (countdownSeconds > 0)
            {
                countdownSeconds--; // Decrement countdown
                label1.Text = $"Countdown: {countdownSeconds} seconds";
            }
            else
            {
                timer1.Stop(); // Stop the timer when countdown reaches 0
                MessageBox.Show("Time's up!");

                this.panel2.Enabled = false;
                this.clearButton.Enabled = false;
                this.checkButton.Enabled = false;
                this.solutionButton.Enabled = true;


            }
        }

    }
}
