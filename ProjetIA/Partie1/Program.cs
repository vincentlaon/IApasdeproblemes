using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Partie1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAccueil());

            List<Question> questions = new List<Question>();
            questions.Add(new Question("Enoncé 1", "A","B","C","D",0));
            questions.Add(new Question("Enoncé 2", "Coucou ", "Biche", "Calanques", "Doudou", 1));
            questions.Add(new Question("Enoncé 3", "Asticot", "Black", "CroqueMonsieur", "Donner", 2));

            StreamWriter writer = new StreamWriter("questions.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
            serializer.Serialize(writer, questions);
            writer.Close();
        }
    }
}
