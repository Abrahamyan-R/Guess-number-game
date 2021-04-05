using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class frmGuessNumber : Form
    {
        int numberToBeGuessed;
        int guessNumberMinBound;
        int guessNumberMaxBound;
        bool isStepPerformed;
        Random numberGenerator;
        GameStatus gameStatus;
        GameMode gameMode;
        enum Action
        {
            PLAYER,
            COMPUTER
        }
        enum GameStatus
        {
            IN_PROGRESS,
            FINISHED
        }
        enum GameMode
        {
            EASY,
            HARD
        }

        public frmGuessNumber()
        {
            InitializeComponent();
        }

        private void frmGuessNumber_Load(object sender, EventArgs e)
        {
            gameStatus = GameStatus.FINISHED;
            numberGenerator = new Random();
        }

        private void switchTurn(Action turn)
        {
            switch (turn)
            {
                case Action.PLAYER:
                    gbPlayer.Enabled = true;
                    gbComputer.Enabled = false;
                    txtPlayerGuessNumber.Focus();
                    this.AcceptButton = btnPlayerGuess;
                    break;
                case Action.COMPUTER:
                    gbPlayer.Enabled = false;
                    gbComputer.Enabled = true;
                    txtComputerGuessNumber.Focus();
                    this.AcceptButton = btnAcceptAnswer;
                    break;
            }
        }

        private void btnPlayerGuess_Click(object sender, EventArgs e)
        {
            int predictableNumber;

            bool isPredictableNumberInteger = int.TryParse(txtPlayerGuessNumber.Text, out predictableNumber);
            if (!isPredictableNumberInteger)
            {
                MessageBox.Show("Մուտքագրեք թիվ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isPredictableNumberFromCorrectRange = predictableNumber >= 1 && predictableNumber <= 100;
            if (!isPredictableNumberFromCorrectRange)
            {
                MessageBox.Show("Մուտքագրված թիվը պետք է լինի 1-ից 100 միջակայքից", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (predictableNumber == numberToBeGuessed)
            {
                finishGame();
                incrementScore(Action.PLAYER);
                MessageBox.Show("Շնորհավորում ենք, Դուք հաղթեցիք", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (predictableNumber > numberToBeGuessed)
            {
                lstSteps.Items.Add(predictableNumber + " > x");
                MessageBox.Show("Մուտքագրված թիվը մեծ է մտապահված թվից", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstSteps.Items.Add(predictableNumber + " < x");
                MessageBox.Show("Մուտքագրված թիվը փոքր է մտապահված թվից", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            isStepPerformed = true;

            switchTurn(Action.COMPUTER);
            performComputerStep();
        }

        private void performComputerStep()
        {
            int consideredNumber;
            if (gameMode == GameMode.HARD)
            {
                consideredNumber = (guessNumberMinBound + guessNumberMaxBound) / 2;
            }
            else
            {
                consideredNumber = numberGenerator.Next(1, 101);
            }
            txtComputerGuessNumber.Text = consideredNumber.ToString();
        }

        private void btnAcceptAnswer_Click(object sender, EventArgs e)
        {
            if (rbEqual.Checked)
            {
                finishGame();
                incrementScore(Action.COMPUTER);
                MessageBox.Show("Դուք պարտվեցիք", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gameMode == GameMode.HARD)
            {
                if (rbGreater.Checked)
                {
                    int guessNumberMaxBound = int.Parse(txtComputerGuessNumber.Text);
                }
                else
                {
                    int guessNumberMinBound = int.Parse(txtComputerGuessNumber.Text);
                }
                this.Text = guessNumberMinBound + " " + guessNumberMaxBound;
                if (guessNumberMinBound >= guessNumberMaxBound)
                {
                    MessageBox.Show("Դուք պարտվեցիք, հարցերին պատասխանել եք սխալ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    incrementScore(Action.COMPUTER);
                    finishGame();
                    return;
                }
            }

            switchTurn(Action.PLAYER);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (gameStatus == GameStatus.IN_PROGRESS)
            {
                if (MessageBox.Show("Ցանկանում եք ավարտել ընթացիկ խաղը՞", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    finishGame();
                    if (isStepPerformed)
                    {
                        incrementScore(Action.COMPUTER);
                    }
                    initializeNewGame();
                }
            }
            else
            {
                initializeNewGame();
            }
        }

        private void initializeNewGame()
        {
            numberToBeGuessed = numberGenerator.Next(1, 101);
            guessNumberMinBound = 1;
            guessNumberMaxBound = 100;
            gameStatus = GameStatus.IN_PROGRESS;
            gameMode = rbGameEasyMode.Checked ? GameMode.EASY : GameMode.HARD;
            lstSteps.Visible = gameMode == GameMode.EASY;
            lstSteps.Items.Clear();
            rbEqual.Checked = true;
            isStepPerformed = false;

            switchTurn(Action.PLAYER);
        }

        private void incrementScore(Action score)
        {
            switch (score)
            {
                case Action.PLAYER:
                    int playerScore = int.Parse(lblPlayerScore.Text);
                    playerScore++;
                    lblPlayerScore.Text = playerScore.ToString();
                    break;
                case Action.COMPUTER:
                    int computerScore = int.Parse(lblComputerScore.Text);
                    computerScore++;
                    lblComputerScore.Text = computerScore.ToString();
                    break;
            }
        }

        private void finishGame()
        {
            txtComputerGuessNumber.Clear();
            txtPlayerGuessNumber.Clear();
            gbComputer.Enabled = false;
            gbPlayer.Enabled = false;
            gameStatus = GameStatus.FINISHED;
        }
    }
}