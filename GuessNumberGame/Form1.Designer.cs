namespace GuessNumberGame
{
    partial class frmGuessNumber
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.btnPlayerGuess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerGuessNumber = new System.Windows.Forms.TextBox();
            this.gbComputer = new System.Windows.Forms.GroupBox();
            this.btnAcceptAnswer = new System.Windows.Forms.Button();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbGreater = new System.Windows.Forms.RadioButton();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComputerGuessNumber = new System.Windows.Forms.TextBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.gbGameMode = new System.Windows.Forms.GroupBox();
            this.rbGameHardMode = new System.Windows.Forms.RadioButton();
            this.rbGameEasyMode = new System.Windows.Forms.RadioButton();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.gbPlayer.SuspendLayout();
            this.gbComputer.SuspendLayout();
            this.gbGame.SuspendLayout();
            this.gbGameMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.lstSteps);
            this.gbPlayer.Controls.Add(this.btnPlayerGuess);
            this.gbPlayer.Controls.Add(this.label1);
            this.gbPlayer.Controls.Add(this.txtPlayerGuessNumber);
            this.gbPlayer.Enabled = false;
            this.gbPlayer.Location = new System.Drawing.Point(12, 12);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(387, 389);
            this.gbPlayer.TabIndex = 0;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Խաղացող";
            // 
            // btnPlayerGuess
            // 
            this.btnPlayerGuess.Location = new System.Drawing.Point(31, 53);
            this.btnPlayerGuess.Name = "btnPlayerGuess";
            this.btnPlayerGuess.Size = new System.Drawing.Size(131, 40);
            this.btnPlayerGuess.TabIndex = 2;
            this.btnPlayerGuess.Text = "Գուշակել";
            this.btnPlayerGuess.UseVisualStyleBackColor = true;
            this.btnPlayerGuess.Click += new System.EventHandler(this.btnPlayerGuess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Թիվ";
            // 
            // txtPlayerGuessNumber
            // 
            this.txtPlayerGuessNumber.Location = new System.Drawing.Point(62, 27);
            this.txtPlayerGuessNumber.Name = "txtPlayerGuessNumber";
            this.txtPlayerGuessNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerGuessNumber.TabIndex = 0;
            // 
            // gbComputer
            // 
            this.gbComputer.Controls.Add(this.btnAcceptAnswer);
            this.gbComputer.Controls.Add(this.rbLess);
            this.gbComputer.Controls.Add(this.rbGreater);
            this.gbComputer.Controls.Add(this.rbEqual);
            this.gbComputer.Controls.Add(this.label2);
            this.gbComputer.Controls.Add(this.txtComputerGuessNumber);
            this.gbComputer.Enabled = false;
            this.gbComputer.Location = new System.Drawing.Point(405, 12);
            this.gbComputer.Name = "gbComputer";
            this.gbComputer.Size = new System.Drawing.Size(195, 392);
            this.gbComputer.TabIndex = 1;
            this.gbComputer.TabStop = false;
            this.gbComputer.Text = "Համակարգիչ";
            // 
            // btnAcceptAnswer
            // 
            this.btnAcceptAnswer.Location = new System.Drawing.Point(16, 100);
            this.btnAcceptAnswer.Name = "btnAcceptAnswer";
            this.btnAcceptAnswer.Size = new System.Drawing.Size(131, 40);
            this.btnAcceptAnswer.TabIndex = 5;
            this.btnAcceptAnswer.Text = "Հաստատել";
            this.btnAcceptAnswer.UseVisualStyleBackColor = true;
            this.btnAcceptAnswer.Click += new System.EventHandler(this.btnAcceptAnswer_Click);
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Location = new System.Drawing.Point(153, 74);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(31, 17);
            this.rbLess.TabIndex = 4;
            this.rbLess.Text = "<";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbGreater
            // 
            this.rbGreater.AutoSize = true;
            this.rbGreater.Location = new System.Drawing.Point(153, 28);
            this.rbGreater.Name = "rbGreater";
            this.rbGreater.Size = new System.Drawing.Size(31, 17);
            this.rbGreater.TabIndex = 3;
            this.rbGreater.Text = ">";
            this.rbGreater.UseVisualStyleBackColor = true;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Checked = true;
            this.rbEqual.Location = new System.Drawing.Point(153, 51);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(31, 17);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "=";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Թիվ";
            // 
            // txtComputerGuessNumber
            // 
            this.txtComputerGuessNumber.Enabled = false;
            this.txtComputerGuessNumber.Location = new System.Drawing.Point(47, 52);
            this.txtComputerGuessNumber.Name = "txtComputerGuessNumber";
            this.txtComputerGuessNumber.Size = new System.Drawing.Size(100, 20);
            this.txtComputerGuessNumber.TabIndex = 0;
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.gbGameMode);
            this.gbGame.Controls.Add(this.lblComputerScore);
            this.gbGame.Controls.Add(this.label4);
            this.gbGame.Controls.Add(this.lblPlayerScore);
            this.gbGame.Controls.Add(this.label3);
            this.gbGame.Controls.Add(this.btnNewGame);
            this.gbGame.Location = new System.Drawing.Point(606, 12);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(147, 392);
            this.gbGame.TabIndex = 2;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Խաղ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Հաշիվ";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(6, 62);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(131, 40);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Նոր խաղ";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(61, 33);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(15, 16);
            this.lblPlayerScore.TabIndex = 8;
            this.lblPlayerScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.Location = new System.Drawing.Point(96, 33);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(15, 16);
            this.lblComputerScore.TabIndex = 10;
            this.lblComputerScore.Text = "0";
            // 
            // gbGameMode
            // 
            this.gbGameMode.Controls.Add(this.rbGameHardMode);
            this.gbGameMode.Controls.Add(this.rbGameEasyMode);
            this.gbGameMode.Location = new System.Drawing.Point(11, 108);
            this.gbGameMode.Name = "gbGameMode";
            this.gbGameMode.Size = new System.Drawing.Size(126, 97);
            this.gbGameMode.TabIndex = 13;
            this.gbGameMode.TabStop = false;
            this.gbGameMode.Text = "Ռեժիմ";
            // 
            // rbGameHardMode
            // 
            this.rbGameHardMode.AutoSize = true;
            this.rbGameHardMode.Location = new System.Drawing.Point(34, 51);
            this.rbGameHardMode.Name = "rbGameHardMode";
            this.rbGameHardMode.Size = new System.Drawing.Size(59, 17);
            this.rbGameHardMode.TabIndex = 14;
            this.rbGameHardMode.Text = "Դժվար";
            this.rbGameHardMode.UseVisualStyleBackColor = true;
            // 
            // rbGameEasyMode
            // 
            this.rbGameEasyMode.AutoSize = true;
            this.rbGameEasyMode.Checked = true;
            this.rbGameEasyMode.Location = new System.Drawing.Point(34, 28);
            this.rbGameEasyMode.Name = "rbGameEasyMode";
            this.rbGameEasyMode.Size = new System.Drawing.Size(50, 17);
            this.rbGameEasyMode.TabIndex = 13;
            this.rbGameEasyMode.TabStop = true;
            this.rbGameEasyMode.Text = "Հեշտ";
            this.rbGameEasyMode.UseVisualStyleBackColor = true;
            // 
            // lstSteps
            // 
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.Location = new System.Drawing.Point(180, 19);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(176, 329);
            this.lstSteps.TabIndex = 3;
            this.lstSteps.Visible = false;
            // 
            // frmGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 519);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbComputer);
            this.Controls.Add(this.gbPlayer);
            this.Name = "frmGuessNumber";
            this.Text = "Գուշակիր թիվը";
            this.Load += new System.EventHandler(this.frmGuessNumber_Load);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbComputer.ResumeLayout(false);
            this.gbComputer.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            this.gbGameMode.ResumeLayout(false);
            this.gbGameMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.Button btnPlayerGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerGuessNumber;
        private System.Windows.Forms.GroupBox gbComputer;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbGreater;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComputerGuessNumber;
        private System.Windows.Forms.Button btnAcceptAnswer;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.GroupBox gbGameMode;
        private System.Windows.Forms.RadioButton rbGameHardMode;
        private System.Windows.Forms.RadioButton rbGameEasyMode;
        private System.Windows.Forms.ListBox lstSteps;
    }
}

