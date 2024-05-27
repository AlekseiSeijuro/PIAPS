using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace lab7
{
    class Controller : ControllerI
    {
        Form1I view;
        public Controller()
        {

            view = new Form1();
            view.addCreateButtonListener(this.createOtchet);
            Application.Run((Form1)view);

        }

        public void createOtchet(object sender, EventArgs e)
        {
            try
            {
                Word.Application wordapp = new Word.Application();
                wordapp.Visible = false;

                var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                Word.Document tempDoc = wordapp.Documents.Open(Path.Combine(appDir, @"template.docx"));

                Word.Document newDocument = wordapp.Documents.Add();

                tempDoc.Content.Copy();
                newDocument.Content.Paste();

                tempDoc.Close();

                Word.Range Range = newDocument.Content;

                Range.Find.Execute("$(Название дисциплины)$");
                Range.Text = view.getDisciplineName();

                Range = newDocument.Content;
                Range.Find.Execute("$(Номер лабы)$");
                Range.Text = view.getLabNum();

                Range = newDocument.Content;
                Range.Find.Execute("$(Название лабы)$");
                Range.Text = view.getLabName();

                Range = newDocument.Content;
                Range.Find.Execute("$(Группа)$");
                Range.Text = view.getGroupName();

                Range = newDocument.Content;
                Range.Find.Execute("$(ФИО студента)$");
                Range.Text = view.getYourFio();

                Range = newDocument.Content;
                Range.Find.Execute("$(ФИО преподователя)$");
                Range.Text = view.getTeacherFio();

                wordapp.ActiveDocument.SaveAs(Path.Combine(appDir, @"отчёт " + view.getLabName() + ".docx"), Word.WdSaveFormat.wdFormatDocumentDefault);

                wordapp.Quit();
                view.showMessage("Отчёт сгнерирован", "Успех");
                
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                view.showMessage("Не найден шаблон, пожалйста, добавьте его.", "Шаблон не найден");
            }
        }
    }
}
