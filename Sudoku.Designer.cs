namespace SudokuApp
{
    partial class Sudoku
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            difficulty = new TextBox();
            testLevel = new RadioButton();
            clearButton = new Button();
            hardLevel = new RadioButton();
            mediumLevel = new RadioButton();
            easyLevel = new RadioButton();
            checkButton = new Button();
            solutionButton = new Button();
            newGameButton = new Button();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(difficulty);
            panel1.Controls.Add(testLevel);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(hardLevel);
            panel1.Controls.Add(mediumLevel);
            panel1.Controls.Add(easyLevel);
            panel1.Controls.Add(checkButton);
            panel1.Controls.Add(solutionButton);
            panel1.Controls.Add(newGameButton);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(25, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 770);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SpringGreen;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(790, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 11;
            label1.Text = "Countdown:";
            // 
            // difficulty
            // 
            difficulty.BackColor = Color.SpringGreen;
            difficulty.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            difficulty.Location = new Point(834, 352);
            difficulty.Name = "difficulty";
            difficulty.Size = new Size(132, 38);
            difficulty.TabIndex = 10;
            difficulty.Text = "DIFFICULTY";
            // 
            // testLevel
            // 
            testLevel.AutoSize = true;
            testLevel.BackColor = Color.SpringGreen;
            testLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testLevel.Location = new Point(834, 519);
            testLevel.Name = "testLevel";
            testLevel.Size = new Size(86, 35);
            testLevel.TabIndex = 9;
            testLevel.TabStop = true;
            testLevel.Text = "TEST";
            testLevel.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.SpringGreen;
            clearButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(834, 165);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(224, 72);
            clearButton.TabIndex = 8;
            clearButton.Text = "CLEAR INPUT";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // hardLevel
            // 
            hardLevel.AutoSize = true;
            hardLevel.BackColor = Color.SpringGreen;
            hardLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hardLevel.Location = new Point(834, 478);
            hardLevel.Name = "hardLevel";
            hardLevel.Size = new Size(101, 35);
            hardLevel.TabIndex = 7;
            hardLevel.TabStop = true;
            hardLevel.Text = "HARD";
            hardLevel.UseVisualStyleBackColor = false;
            // 
            // mediumLevel
            // 
            mediumLevel.AutoSize = true;
            mediumLevel.BackColor = Color.SpringGreen;
            mediumLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mediumLevel.Location = new Point(834, 437);
            mediumLevel.Name = "mediumLevel";
            mediumLevel.Size = new Size(132, 35);
            mediumLevel.TabIndex = 6;
            mediumLevel.TabStop = true;
            mediumLevel.Text = "MEDIUM";
            mediumLevel.UseVisualStyleBackColor = false;
            // 
            // easyLevel
            // 
            easyLevel.AutoSize = true;
            easyLevel.BackColor = Color.SpringGreen;
            easyLevel.Checked = true;
            easyLevel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            easyLevel.Location = new Point(834, 396);
            easyLevel.Name = "easyLevel";
            easyLevel.Size = new Size(90, 35);
            easyLevel.TabIndex = 5;
            easyLevel.TabStop = true;
            easyLevel.Text = "EASY";
            easyLevel.UseVisualStyleBackColor = false;
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.SpringGreen;
            checkButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkButton.Location = new Point(834, 243);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(224, 72);
            checkButton.TabIndex = 4;
            checkButton.Text = "CHECK INPUT";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // solutionButton
            // 
            solutionButton.BackColor = Color.SpringGreen;
            solutionButton.Enabled = false;
            solutionButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solutionButton.Location = new Point(834, 663);
            solutionButton.Name = "solutionButton";
            solutionButton.Size = new Size(224, 72);
            solutionButton.TabIndex = 3;
            solutionButton.Text = "SOLUTION";
            solutionButton.UseVisualStyleBackColor = false;
            solutionButton.Click += solutionButton_Click;
            // 
            // newGameButton
            // 
            newGameButton.BackColor = Color.SpringGreen;
            newGameButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newGameButton.Location = new Point(834, 585);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(224, 72);
            newGameButton.TabIndex = 2;
            newGameButton.Text = "NEW GAME";
            newGameButton.UseVisualStyleBackColor = false;
            newGameButton.Click += newGameButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(28, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 720);
            panel2.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Sudoku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1182, 823);
            Controls.Add(panel1);
            Name = "Sudoku";
            Text = "Sudoku";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button newGameButton;
        private Button checkButton;
        private Button solutionButton;
        private RadioButton hardLevel;
        private RadioButton mediumLevel;
        private RadioButton easyLevel;
        private Button clearButton;
        private RadioButton testLevel;
        private TextBox difficulty;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
