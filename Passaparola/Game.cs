
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Game : Form
    {

        int remainingTime = 120, correctNumber = 0, wrongNumber = 0, totalPoints = 0;
        Label[] labelList = new Label[26];
        Timer remainingTimer = new Timer();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer wplayerAnswers = new WMPLib.WindowsMediaPlayer();

        QuestionList qList = new QuestionList();
        string currentQuestion, currentAnswer;
        String curDir = Directory.GetCurrentDirectory(); 

        public Game()
        {
            InitializeComponent();
            startTimer();
            SetLabels();
            changeQuestion();
        }
        
        private void startTimer()
        {
            remainingTimer.Interval = 1000;
            remainingTimer.Tick += new EventHandler(changeRemainingTime);
            remainingTimer.Start();
        }

        private void SetLabels()
        {
            foreach (Control c in gamegb.Controls)
            {
                if (c.Name.Length == 6)
                {
                    labelList[(c.Name[5] - 65)] = (Label)c;
                }
            }
        }

        private void changeRemainingTime(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                time.Text = remainingTime.ToString();
                wplayer.URL = curDir + @"\Tick.mp3";
                wplayer.controls.play();
            }

            else if (remainingTime == 0)
            {
                showResults();
            }
            remainingTime--;
        }

        private void showResults()
        {
            remainingTimer.Stop();
            this.Dispose();
            Result r = new Result(correctNumber, wrongNumber, totalPoints, remainingTime);
            r.Show();
        }

        private void changeQuestion()
        {
            KeyValuePair<string, string> qa = qList.getNextQuestion();
            currentQuestion = qa.Value;
            currentAnswer = qa.Key;

            if (currentAnswer.ToLower() + currentQuestion.ToLower() == "gameover")
            {
                showResults();
            }
            else
            {
                questionLabel.Text = currentQuestion;
                currentLetterLabel.Text = currentAnswer[0].ToString();
                corrects.Text = correctNumber.ToString();
                wrongs.Text = wrongNumber.ToString();
                points.Text = totalPoints.ToString();
            }
        }

        private void answerLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (String.IsNullOrWhiteSpace(answerLabel.Text))
                {
                    labelList[currentAnswer[0] - 65].BackColor = System.Drawing.Color.Yellow;
                    answerLabel.Clear();
                    qList.passQuestion(currentQuestion, currentAnswer);
                    changeQuestion();
                    answerLabel.Focus();
                }
                else
                    checkAnswer();
            }
        }

        private void checkAnswer()
        {
            string answer = answerLabel.Text.ToLower();

            if (currentAnswer[0] == 'I')
            {
                currentAnswer = "i" + currentAnswer.Substring(1);
            }

            if (answer != "" && answer[0] == 'ı')
            {
                answer = "i" + answer.Substring(1);
            }

            if (answer == currentAnswer.ToLower())
            {
                wplayerAnswers.URL = curDir + @"\correct.mp3";
                wplayerAnswers.controls.play();
                labelList[currentLetterLabel.Text[0] - 65].BackColor = System.Drawing.Color.SpringGreen;
                totalPoints += 100;
                correctNumber++;
            }
            else
            {
                labelList[currentLetterLabel.Text[0] - 65].BackColor = System.Drawing.Color.Red;
                wplayerAnswers.URL = curDir + @"\wrong.mp3";
                wplayerAnswers.controls.play();
                totalPoints -= 200;
                wrongNumber++;
            }

            answerLabel.Clear();
            changeQuestion();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            labelList[currentAnswer[0] - 65].BackColor = System.Drawing.Color.Yellow;
            answerLabel.Clear();
            qList.passQuestion(currentQuestion, currentAnswer);
            changeQuestion();
            answerLabel.Focus();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
