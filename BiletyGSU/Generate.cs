using Microsoft.Office.Interop.Word;
using System;
using Application = Microsoft.Office.Interop.Word.Application;
using Range = Microsoft.Office.Interop.Word.Range;

namespace BiletyGSU
{
    internal class Generate
    {
        public static string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static Ticket[] GetTickets(string[] strings)
        {
            var count = strings.Length % 2 == 0 ? strings.Length / 2 : strings.Length / 2 + 1;
            var tickets = new Ticket[count];

            for(int i = 0; i < count; i++)
            {
                if (count + i == strings.Length)
                {
                    tickets[i] = new Ticket(i + 1, strings[i], strings[new Random().Next(strings.Length)]);
                    break;
                }
                tickets[i] = new Ticket (i + 1, strings[i], strings[count + i]);
                

            }
            return tickets;

        }

        public static string[] GetQuestions(string[] strings)
        {
            var indexOfFirst = 0;
            var indexOfLast = strings.Length - 1;
            while (true)
            {
                var test = strings[indexOfFirst].Split('\t');
                if (test[0] == "1.")
                {
                    break;
                }
                indexOfFirst++;
            }

            while (true)
            {
                var temp = strings[indexOfLast].Split("\t");
                if (temp[0] != "")
                {
                    break;
                }
                indexOfLast--;
            }

            var list = new List<string>();
            for(int i = indexOfFirst; i <= indexOfLast; i++)
            {
                list.Add(strings[i].Split('\t')[1]);
            }

            return list.ToArray();
        }

        public static void GenerateFile(Ticket[] tickets, string filePath, string discipline, int course, string speciality, string academicYears, string approvalDateDay, string approvalDateMonth, string approvalDateYear, bool isZaochniki)
        {
            var wordApp = new Application();

            Document doc = wordApp.Documents.Add();
            
            foreach(var ticket in tickets)
            {
                InsertLineWithFormatting(doc, "Учреждение образования", "Times New Roman", 13, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                InsertLineWithFormatting(doc, "«Гомельский государственный университет имени Франциска Скорины»", "Times New Roman", 13, true, false, WdParagraphAlignment.wdAlignParagraphCenter);

                InsertLineWithFormatting(doc, "  ", "Times New Roman", 12, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                
                InsertLineWithFormatting(doc, $"ЭКЗАМЕНАЦИОННЫЙ БИЛЕТ №  {ticket.Номер}", "Times New Roman", 12, false, false, WdParagraphAlignment.wdAlignParagraphCenter);
                
                InsertLineWithFormatting(doc, "  ", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                
                InsertLineWithFormatting(doc, "Дисциплина:", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                InsertLineWithFormatting(doc, discipline.ToUpper(), "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);

                if (isZaochniki)
                {
                    InsertLineWithFormatting(doc, $"для студентов {course} курса заочного обучения", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                    InsertLineWithFormatting(doc, $"специальности «{GetSpeciality(speciality).Replace("\r", "")}»", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                    
                }
                else
                {
                    InsertLineWithFormatting(doc, $"для студентов {course} курса", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                    InsertLineWithFormatting(doc, speciality.Replace("\r", ""), "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                }

                InsertLineWithFormatting(doc, $"на {academicYears} учебный год", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);

                InsertLineWithFormatting(doc, "  ", "Times New Roman", 14, true, false, WdParagraphAlignment.wdAlignParagraphCenter);

                InsertLineWithFormatting(doc, $"\t1. {ticket.Вопрос1}", "Times New Roman", 14, false, false, WdParagraphAlignment.wdAlignParagraphJustify);
                InsertLineWithFormatting(doc, $"\t2. {ticket.Вопрос2}", "Times New Roman", 14, false, false, WdParagraphAlignment.wdAlignParagraphJustify);
                InsertLineWithFormatting(doc, $"\t3. Задача", "Times New Roman", 14, false, false, WdParagraphAlignment.wdAlignParagraphJustify);

                InsertLineWithFormatting(doc, "  ", "Times New Roman", 13, true, false, WdParagraphAlignment.wdAlignParagraphCenter);
                InsertLineWithFormatting(doc, "  ", "Times New Roman", 13, true, false, WdParagraphAlignment.wdAlignParagraphCenter);

                InsertLineWithFormatting(doc, "Заведующий кафедрой __________ Преподаватель __________", "Times New Roman", 13, false, false, WdParagraphAlignment.wdAlignParagraphLeft);
                InsertLineWithFormatting(doc, $"Дата утверждения «{approvalDateDay}»    {approvalDateMonth}    {approvalDateYear}г., протокол № _______", "Times New Roman", 13, false, false, WdParagraphAlignment.wdAlignParagraphLeft);

                InsertPageBreakToEnd(doc);
            }

            MessageBox.Show("Билеты сгенерированы!\nИз-за проблем совместимости следует открыть документ -> \nнажать комбинацию клавиш \"CTRL + Ф\" -> макет -> \nинтервал после -> уменьшить");

            doc.SaveAs2(filePath, WdSaveFormat.wdFormatDocumentDefault, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            doc.Close();
            wordApp.Quit();

        }

        public static void InsertLineWithFormatting(Document doc, string text, string fontName, float fontSize, bool isBold, bool isItalic, WdParagraphAlignment alignment)
        {
            object unit = WdUnits.wdStory;
            object extend = WdMovementType.wdMove;
            doc.Application.Selection.EndKey(ref unit, ref extend);

            Range range = doc.Application.Selection.Range;
            range.Text = text;
            
            range.Font.Name = fontName;
            range.Font.Size = fontSize;
            range.Font.Bold = isBold ? 1 : 0;
            range.Font.Italic = isItalic ? 1 : 0;
            range.ParagraphFormat.Alignment = alignment;
            
            Paragraph paragraph = doc.Content.Paragraphs.Add();
            
            paragraph.Range.Font.Name = fontName;
            paragraph.Range.Font.Size = fontSize;
            paragraph.Range.Font.Bold = isBold ? 1 : 0;
            paragraph.Range.Font.Italic = isItalic ? 1 : 0;
            paragraph.Alignment = alignment;
        }

        public static void AppendTextToFile(Document doc, string text, string fontName, int fontSize, bool isBold, bool isItalic, WdParagraphAlignment alignment)
        {
            
            Paragraph paragraph = doc.Content.Paragraphs.Add();
            paragraph.Range.Text = text;

            
            paragraph.Range.Font.Name = fontName;
            paragraph.Range.Font.Size = fontSize;
            paragraph.Range.Font.Bold = isBold ? 1 : 0;
            paragraph.Range.Font.Italic = isItalic ? 1 : 0;
            paragraph.Alignment = alignment;
        }


        public static void AppendTextToEnd(Document doc, string text, string fontName, int fontSize, bool isBold, bool isItalic, WdParagraphAlignment alignment)
        {
            
            object unit = WdUnits.wdStory;
            object extend = WdMovementType.wdMove;
            doc.Application.Selection.EndKey(ref unit, ref extend);

            
            doc.Application.Selection.TypeText(text);

            
            doc.Application.Selection.Font.Name = fontName;
            doc.Application.Selection.Font.Size = fontSize;
            doc.Application.Selection.Font.Bold = isBold ? 1 : 0;
            doc.Application.Selection.Font.Italic = isItalic ? 1 : 0;
            doc.Application.Selection.ParagraphFormat.Alignment = alignment;
        }

        public static void InsertPageBreakToEnd(Document wordDoc)
        {
            
            object unit = WdUnits.wdStory;
            object extend = WdMovementType.wdMove;
            wordDoc.Application.Selection.EndKey(ref unit, ref extend);

            
            object pageBreakType = WdBreakType.wdPageBreak;
            wordDoc.Application.Selection.InsertBreak(pageBreakType);
        }

        public static string GetSpeciality(string speciality)
        {
            int indexOfLastNumber = speciality.Length - 1;
            while (true)
            {
                if (speciality[indexOfLastNumber] >= '0' && speciality[indexOfLastNumber] <= '9')
                {
                    return speciality.Substring(indexOfLastNumber + 2);
                }
                indexOfLastNumber--;
            }
        }

        public static Ticket[] GenerateRandomTickets(string[] questions)
        {
            var random = new Random();
            int totalQuestions = questions.Length;
            int ticketCount = totalQuestions / 2; 

            if (totalQuestions % 2 == 1)
                ticketCount++; 

            var shuffledQuestions = questions.OrderBy(q => random.Next()).ToArray();
            var tickets = new Ticket[ticketCount];

            for (int i = 0; i < ticketCount; i++)
            {
                int index = i * 2; 

                string question1 = shuffledQuestions[index];

                string question2;
                if (i == ticketCount - 1 && totalQuestions % 2 == 1)
                    question2 = shuffledQuestions[totalQuestions - 1]; 
                else
                    question2 = shuffledQuestions[index + 1];

                tickets[i] = new Ticket(i + 1, question1, question2);
            }

            return tickets;
        }
    }
}
