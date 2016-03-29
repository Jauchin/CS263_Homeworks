using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Grade
    {
        private float score;

        public float Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if (value < 0)
                    this.score = 0;
                else if (value > 100)
                    this.score = 100;
                else
                    this.score = value;
            }
        }

        private string level;

        public string subject;

        public string Level
        {
            get
            {
                //         if(this.score >=90)
                //             this.level="A+";
                //         else if(this.score>=80)
                //             this.level="B+";

                int b = (int)score / 10;
                switch (b)
                {
                    case 10:
                    case 9:
                        this.level = "A";
                        break;

                    case 8:
                    case 7:
                        this.level = "B";
                        break;

                    default:
                        this.level = "F";
                        break;
                }
                return this.level;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("科目: {0}\n", this.subject);
            result += string.Format("原始成績: {0}\n", this.score);
            result += string.Format("Level: {0}", this.Level);
            return result;
        }
    }
}