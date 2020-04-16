using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse.MediaLibrary
{
    class VideoGames
    {
        public readonly string Title;       // field added to the class
        public readonly int Published;      // field added to the class
        public readonly string Developer;   // field added to the class
        public string Loanee;
        public bool OnLoan;

        public VideoGames(string title, int published, string developer)
        {
            Title = title;
            Published = published;
            Developer = developer;
        }

        public void Loan()
        {
            OnLoan = true;
        }

        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }

        

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }


        // add method to class
        public string GetDisplayText()
        {
            string text = $"VideoGames: {Title} by {Developer} published {Published}";

            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text += " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on loan)";
                }

            }

            return text;
        }
    }
}
