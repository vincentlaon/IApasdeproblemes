using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1
{
    [Serializable]
    class Question
    {
        public string enonce { get; set; }
        public string[] reponses { get; set; }
        public int bonneReponse { get; set; }

        //Constructeur

        public Question(string quest, string repA, string repB, string repC, string repD, int bonneRep)
        {
            this.enonce = quest;
            this.reponses = new string [] { repA, repB, repC, repD };
            this.bonneReponse = bonneRep;            

        }

        

    }
}
