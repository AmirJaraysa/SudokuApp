namespace SudokuApp
{
    class Cells : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; } = true;
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }
    }
}
