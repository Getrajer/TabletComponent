using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabletComponent.Pages
{
    public class TabletBase : ComponentBase
    {


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

            //Wallpaper 
            current_wallpeper.Id = 0;
            current_wallpeper.Style = "wallpaper1";

            Wallpaper w1 = new Wallpaper();
            w1.Id = 0;
            w1.Path = "../images/wallpaper1.jpg";
            w1.Style = "wallpaper1";
            wallpapers.Add(w1);

            Wallpaper w2 = new Wallpaper();
            w2.Id = 1;
            w2.Path = "../images/wallpaper2.jpg";
            w2.Style = "wallpaper2";
            wallpapers.Add(w2);

            Wallpaper w3 = new Wallpaper();
            w3.Id = 2;
            w3.Path = "../images/wallpaper3.jpg";
            w3.Style = "wallpaper3";
            wallpapers.Add(w3);

            Wallpaper w4 = new Wallpaper();
            w4.Id = 3;
            w4.Path = "../images/wallpaper4.jpg";
            w4.Style = "wallpaper4";
            wallpapers.Add(w4);

            Wallpaper w5 = new Wallpaper();
            w5.Id = 4;
            w5.Path = "../images/wallpaper5.jpg";
            w5.Style = "wallpaper5";
            wallpapers.Add(w5);

            Wallpaper w6 = new Wallpaper();
            w6.Id = 5;
            w6.Path = "../images/wallpaper6.jpg";
            w6.Style = "wallpaper6";
            wallpapers.Add(w6);

            //Gallery

            Img i1 = new Img();

            i1.Id = 0;
            i1.Path = "https://images.pexels.com/photos/70912/pexels-photo-70912.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260";
            i1.Alt = "BMW";
            i1.Title = "BMW";
            i1.Alt = "BMW Car";
            i1.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur et nibh ac pellentesque. Suspendisse odio leo, semper sit amet leo sit amet, ultrices molestie erat. ";

            images.Add(i1);

            Img i2 = new Img();

            i2.Id = 1;
            i2.Path = "https://images.pexels.com/photos/1149831/pexels-photo-1149831.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260";
            i2.Alt = "Audi";
            i2.Title = "Audi";
            i2.Alt = "Audi Car";
            i2.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur et nibh ac pellentesque. Suspendisse odio leo, semper sit amet leo sit amet, ultrices molestie erat. ";

            images.Add(i2);

            Img i3 = new Img();

            i3.Id = 2;
            i3.Path = "https://images.pexels.com/photos/120049/pexels-photo-120049.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260";
            i3.Alt = "Mercedes";
            i3.Title = "Mercedes";
            i3.Alt = "Mercedes Car";
            i3.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur et nibh ac pellentesque. Suspendisse odio leo, semper sit amet leo sit amet, ultrices molestie erat. ";

            images.Add(i3);

            Img i4 = new Img();

            i4.Id = 3;
            i4.Path = "https://images.pexels.com/photos/544542/pexels-photo-544542.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260";
            i4.Alt = "Mustang";
            i4.Title = "Mustang";
            i4.Alt = "Mustang Car";
            i4.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur et nibh ac pellentesque. Suspendisse odio leo, semper sit amet leo sit amet, ultrices molestie erat. ";

            images.Add(i4);

            Img i5 = new Img();

            i5.Id = 4;
            i5.Path = "https://images.pexels.com/photos/2920064/pexels-photo-2920064.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260";
            i5.Alt = "Hundai";
            i5.Title = "Hundai";
            i5.Alt = "Hundai Car";
            i5.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur et nibh ac pellentesque. Suspendisse odio leo, semper sit amet leo sit amet, ultrices molestie erat. ";

            images.Add(i5);

            Img i6 = new Img();

            i6.Id = 5;
            i6.Path = "https://images.pexels.com/photos/3972755/pexels-photo-3972755.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260";
            i6.Alt = "Lamborghini";
            i6.Title = "Lamborghini";
            i6.Alt = "Lamborghini Car";
            i6.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur et nibh ac pellentesque. Suspendisse odio leo, semper sit amet leo sit amet, ultrices molestie erat. ";

            images.Add(i6);

        }



        #region Variables and functions for toggleing apps within tablet
        protected bool show_main_screen = false;
        protected bool show_chat_app = false;
        protected bool show_live_app = false;
        protected bool show_options_screen = false;
        protected bool show_internet_app = false;
        protected bool show_gallery_app = true;
        protected bool show_skills_app = false;

        public void CloseAllApps()
        {
            show_chat_app = false;
            show_main_screen = false;
            show_live_app = false;
            show_options_screen = false;
            show_internet_app = false;
            show_gallery_app = false;
            show_skills_app = false;
            display_img = false;
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

        /// <summary>
        /// Will open live app screen
        /// </summary>
        public void OpenLiveApp()
        {
            if (show_live_app == false)
            {
                CloseAllApps();
                show_live_app = true;
            }
            else
            {
                CloseAllApps();
                show_live_app = true;
            }
        }

        /// <summary>
        /// This function will open options window
        /// </summary>
        public void OpenOptions()
        {
            if (show_options_screen == false)
            {
                CloseAllApps();
                show_options_screen = true;
            }
            else
            {
                CloseAllApps();
                show_options_screen = true;
            }
        }

        /// <summary>
        /// Will open internet app
        /// </summary>
        public void OpenInternetApp()
        {
            if (show_internet_app == false)
            {
                CloseAllApps();
                show_internet_app = true;
            }
            else
            {
                CloseAllApps();
                show_internet_app = true;
            }
        }

        /// <summary>
        /// Will open gallery app
        /// </summary>
        public void OpenGalleryApp()
        {
            if (show_gallery_app == false)
            {
                CloseAllApps();
                show_gallery_app = true;
            }
            else
            {
                CloseAllApps();
                show_gallery_app = true;
            }
        }

        /// <summary>
        /// Will open skills display
        /// </summary>
        public void OpenSkillsApp()
        {
            if (show_skills_app == false)
            {
                CloseAllApps();
                show_skills_app = true;
            }
            else
            {
                CloseAllApps();
                show_skills_app = true;
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

        #region Options Functions
        public class Wallpaper
        {
            public int Id { get; set; }
            public string Style { get; set; }
            public string Path { get; set; }

            public Wallpaper() { }
        }

        /// <summary>
        /// Current walpaper class
        /// </summary>
        protected Wallpaper current_wallpeper = new Wallpaper();


        /// <summary>
        /// Will store wallpapers for the tablet
        /// </summary>
        protected List<Wallpaper> wallpapers = new List<Wallpaper>();

        /// <summary>
        /// Will change wallpaper of tablet
        /// </summary>
        public void ChangeCurrentWallpaper(int id)
        {
            if(wallpapers.Count > 0)
            {
                current_wallpeper = wallpapers[id];
            }
        }

        /// <summary>
        /// Current color scheme for the tablet
        /// </summary>
        protected string ActualScheme = "Scheme_1";

        /// <summary>
        /// Will change color scheme of the tablet
        /// </summary>
        /// <param name="id"></param>
        public void ChangeColorScheme(int id)
        {
            switch (id)
            {
                case 1: { ActualScheme = "Scheme_1"; break; }
                case 2: { ActualScheme = "Scheme_2"; break; }
                case 3: { ActualScheme = "Scheme_3"; break; }
                case 4: { ActualScheme = "Scheme_4"; break; }
                case 5: { ActualScheme = "Scheme_5"; break; }
                case 6: { ActualScheme = "Scheme_6"; break; }
                case 7: { ActualScheme = "Scheme_7"; break; }
            }
        }

        #endregion

        #region Gallery variables functions
        public class Img
        {
            public int Id { get; set; }
            public string Path { get; set; }
            public string Alt { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

            public Img() { }
        }

        protected List<Img> images = new List<Img>();

        protected bool display_img = false;

        protected Img current_img = new Img();


        public void OpenImage(int id)
        {
            if (images.Count > 0)
            {
                current_img = images[id];
                display_img = true;
            }

        }

        public void NextImage()
        {
            if (images.Count > 0)
            {
                if (current_img.Id < images.Count - 1)
                {
                    current_img = images[current_img.Id + 1];
                }
                else
                {
                    current_img = images[0];
                }
            }
        }

        public void PreviousImage()
        {
            if (images.Count > 0)
            {
                if (current_img.Id != 0)
                {
                    current_img = images[current_img.Id - 1];
                }
                else
                {
                    current_img = images[images.Count - 1];
                }
            }
        }


        public void CloseGallery()
        {
            current_img = new Img();
            display_img = false;
        }

        #endregion
    }
}
