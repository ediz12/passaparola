using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Passaparola
{
    class QuestionList
    {
        private Dictionary<string, string> gameQuestions;
        private Dictionary<string, string> passedQuestions = new Dictionary<string, string>();
        IEnumerator nextQuestion;

        public QuestionList()
        {
            String curDir = Directory.GetCurrentDirectory();
            StreamReader r = new StreamReader(curDir + @"\QAs.json");
            string json = r.ReadToEnd();
            Dictionary<string, Dictionary<string, string>> qListParsedJson = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);

            Random rand = new Random();

            IEnumerator qListEnum = qListParsedJson.GetEnumerator();

            this.gameQuestions = new Dictionary<string, string>();

            while (qListEnum.MoveNext())
            {
                KeyValuePair<string, Dictionary<string, string>> currentLetterDict = (KeyValuePair<string, Dictionary<string, string>>)qListEnum.Current;
                string letter = currentLetterDict.Key;
                Dictionary<string, string> questions = new Dictionary<string, string>(currentLetterDict.Value);
                List<string> keyList = new List<string>(questions.Keys);
                string answer = keyList[rand.Next(keyList.Count)];
                string question = questions[answer];
                gameQuestions.Add(answer, question);
            }

            nextQuestion = gameQuestions.GetEnumerator();
        }

        public KeyValuePair<string, string> getNextQuestion()
        {
            bool iterated = nextQuestion.MoveNext();
            if (iterated)
            {
                KeyValuePair<string, string> currentQuestion = (KeyValuePair<string, string>)nextQuestion.Current;
                return currentQuestion;
            }
            else
            {
                gameQuestions.Clear();
                foreach (KeyValuePair<string, string> qa in passedQuestions)
                {
                    gameQuestions.Add(qa.Key, qa.Value);
                }

                if (gameQuestions.Count == 0)
                {
                    return new KeyValuePair<string, string>("Game", "Over");
                }
                else
                {
                    passedQuestions.Clear();
                    nextQuestion = gameQuestions.GetEnumerator();
                    nextQuestion.MoveNext();
                    KeyValuePair<string, string> currentQuestion = (KeyValuePair<string, string>)nextQuestion.Current;
                    return currentQuestion;
                }
            }
        }

        public void passQuestion(string question, string answer)
        {
            passedQuestions.Add(answer, question);
        }
    }
}
