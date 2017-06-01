using System;

namespace TietosuojaApp3
{
	public class Question
	{
		public string QuestionToAsk { get; set; }
		public int CorrectAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

		public Question()
		{
			// this is the default constructor that JSONFX wanted.
		}

		public Question(string questionToAsk, int correctAnswer, string answer1, string answer2, string answer3, string answer4)
		{
			QuestionToAsk = questionToAsk;
			CorrectAnswer = correctAnswer;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
		}
	}

}
