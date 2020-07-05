using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabletComponent.Pages
{
    public class TabletBase : ComponentBase
    {

        #region Variables and functions for toggleing apps within tablet
        protected bool show_main_screen = false;
        protected bool show_chat_app = true;


        public void CloseAllApps()
        {
            show_chat_app = false;
            show_main_screen = false;
        }

        /// <summary>
        /// Will open chat window inside of tablet
        /// </summary>
        public void OpenChatApp()
        {
            if(show_chat_app == false)
            {
                CloseAllApps();
                show_chat_app = true;
            }
            else
            {
                CloseAllApps();
                show_main_screen = true;
            }
        }

        /// <summary>
        /// Will open main screen section
        /// </summary>
        public void OpenMainScreen()
        {
            if(show_main_screen == false)
            {
                CloseAllApps();
                show_main_screen = true;
            }
            else
            {
                CloseAllApps();
                show_main_screen = true;
            }
        }
        #endregion

        #region Chat App Functions
        public class ChatAppOutput
        {
            public int Id { get; set; }
            public string Answer { get; set; }
            public string Question { get; set; }

            public ChatAppOutput() { }
        }


        //Question lists
        protected List<ChatAppOutput> new_questions = new List<ChatAppOutput>();
        protected List<ChatAppOutput> asked_questions = new List<ChatAppOutput>();


        protected override async Task OnInitializedAsync()
        {

            ChatAppOutput q1 = new ChatAppOutput();
            q1.Id = 0;
            q1.Question = "What programing language is your favourite?";
            q1.Answer = "C#";

            new_questions.Add(q1);

            ChatAppOutput q2 = new ChatAppOutput();
            q2.Id = 1;
            q2.Question = "Any hoobies?";
            q2.Answer = "Yes, I do like reading about history, going to the gym, playing video games and study about anything interesting no matter in which field.";

            new_questions.Add(q2);

            ChatAppOutput q3 = new ChatAppOutput();
            q3.Id = 2;
            q3.Question = "Which book is your favorite?";
            q3.Answer = "The Witcher Saga";

            new_questions.Add(q3);

            ChatAppOutput q4 = new ChatAppOutput();
            q4.Id = 3;
            q4.Question = "Favorite qote?";
            q4.Answer = "When something is important enough, you do it even if the odds are not in your favor - Elon Musk";

            new_questions.Add(q4);

            ChatAppOutput q5 = new ChatAppOutput();
            q5.Id = 4;
            q5.Question = "What are your ambitions?";
            q5.Answer = "To be good at no matter what I am going to do.";

            new_questions.Add(q5);

            ChatAppOutput q6 = new ChatAppOutput();
            q6.Id = 5;
            q6.Question = "Your best treat?";
            q6.Answer = "I think is that I am good at problem solving, but I am definetly hardworking if I can say so myself.";

            new_questions.Add(q6);

            ChatAppOutput q7 = new ChatAppOutput();
            q7.Id = 6;
            q7.Question = "Your worst treat?";
            q7.Answer = "I would say lack of confidence, but I am definetly working on it.";

            new_questions.Add(q7);

            ChatAppOutput q8 = new ChatAppOutput();
            q8.Id = 7;
            q8.Question = "What is your favorite game?";
            q8.Answer = "So far it is old game called Gothic 2 Night of the Raven.";

            new_questions.Add(q8);


        }


        /// <summary>
        /// User can ask questinon
        /// </summary>
        /// <param name="id"></param>
        public void AskQuestion(int id)
        {
            asked_questions.Add(new_questions[id]);

            DeleteFromNew(id);
        }


        public void DeleteFromNew(int id)
        {
            new_questions.RemoveAt(id);

            //Reset ids
            if (new_questions.Count > 0)
            {
                for (int i = 0; i < new_questions.Count; i++)
                {
                    new_questions[i].Id = i;
                }
            }
        }
        #endregion
    }
}
