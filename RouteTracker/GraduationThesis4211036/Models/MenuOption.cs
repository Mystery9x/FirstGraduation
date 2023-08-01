using System;

namespace GraduationThesis4211036.Models
{
    public class MenuOption
    {
        public string Title { get; set; }
        public Action Action { get; set; }

        public MenuOption(string title, Action action)
        {
            Title = title;
            Action = action;
        }
    }

}
