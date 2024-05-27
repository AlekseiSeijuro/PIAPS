using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    interface Form1I
    {
        string getDisciplineName();
        string getLabNum();
        string getLabName();
        string getGroupName();
        string getYourFio();
        string getTeacherFio();
        void addCreateButtonListener(EventHandler handler);
        void showMessage(string text, string name);
    }
}
