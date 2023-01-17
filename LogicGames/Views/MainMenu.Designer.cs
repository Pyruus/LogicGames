namespace LogicGames.Views;

partial class MainMenu
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
            this.solverRedirectButton = new System.Windows.Forms.Button();
            this.sudokuGameRedirectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playMastermindRedirect = new System.Windows.Forms.Button();
            this.continueSudokuGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solverRedirectButton
            // 
            this.solverRedirectButton.Location = new System.Drawing.Point(12, 40);
            this.solverRedirectButton.Name = "solverRedirectButton";
            this.solverRedirectButton.Size = new System.Drawing.Size(128, 45);
            this.solverRedirectButton.TabIndex = 0;
            this.solverRedirectButton.Text = "Sudoku Solver";
            this.solverRedirectButton.UseVisualStyleBackColor = true;
            this.solverRedirectButton.Click += new System.EventHandler(this.solverRedirectButton_Click);
            // 
            // sudokuGameRedirectButton
            // 
            this.sudokuGameRedirectButton.Location = new System.Drawing.Point(12, 91);
            this.sudokuGameRedirectButton.Name = "sudokuGameRedirectButton";
            this.sudokuGameRedirectButton.Size = new System.Drawing.Size(128, 45);
            this.sudokuGameRedirectButton.TabIndex = 1;
            this.sudokuGameRedirectButton.Text = "Sudoku Game - Easy";
            this.sudokuGameRedirectButton.UseVisualStyleBackColor = true;
            this.sudokuGameRedirectButton.Click += new System.EventHandler(this.sudokuGameRedirectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sudoku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sudoku Game - Hard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mastermind";
            // 
            // playMastermindRedirect
            // 
            this.playMastermindRedirect.Location = new System.Drawing.Point(174, 40);
            this.playMastermindRedirect.Name = "playMastermindRedirect";
            this.playMastermindRedirect.Size = new System.Drawing.Size(128, 45);
            this.playMastermindRedirect.TabIndex = 5;
            this.playMastermindRedirect.Text = "Play";
            this.playMastermindRedirect.UseVisualStyleBackColor = true;
            this.playMastermindRedirect.Click += new System.EventHandler(this.playMastermindRedirect_Click);
            // 
            // continueSudokuGame
            // 
            this.continueSudokuGame.Location = new System.Drawing.Point(12, 193);
            this.continueSudokuGame.Name = "continueSudokuGame";
            this.continueSudokuGame.Size = new System.Drawing.Size(128, 45);
            this.continueSudokuGame.TabIndex = 6;
            this.continueSudokuGame.Text = "Sudoku Game - Continue";
            this.continueSudokuGame.UseVisualStyleBackColor = true;
            this.continueSudokuGame.Visible = false;
            this.continueSudokuGame.Click += new System.EventHandler(this.continueSudokuGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueSudokuGame);
            this.Controls.Add(this.playMastermindRedirect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sudokuGameRedirectButton);
            this.Controls.Add(this.solverRedirectButton);
            this.Name = "MainMenu";
            this.Text = "Logic Games";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button solverRedirectButton;
    private Button sudokuGameRedirectButton;
    private Label label1;
    private Button button1;
    private Label label2;
    private Button playMastermindRedirect;
    private Button continueSudokuGame;
}
