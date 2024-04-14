using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface BankViewI
    {
        void addCursesButtonListener(EventHandler handler);
        void addCursesDynamicButtonListener(EventHandler handler);
        string getValuteInput();
        void showValuteCurses(ValuteCursTableI VCTable);
        void showDynamicValuteCurses(ValuteCursDynamicTableI VCDTable);
    }
}
