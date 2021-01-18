using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModel
{
    public class School
    {
        private string sElementary;
        private string sMiddle;
        private string sHigh;

        public string Elementary
        {
            get
            {
                return sElementary;
            }
            set
            {
                sElementary = value + "초등학교";
            }
        }

        public string Middle
        {
            get
            {
                return sMiddle;
            }
            set
            {
                sMiddle = value + "중학교";
            }
        }

        public string High
        {
            get
            {
                return sHigh;
            }
            set
            {
                sHigh = value + "고등학교";
            }
        }
    }
}
