using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    class CRoom:ACLocation
    {
        protected string m_sDecoration;

        public CRoom(string name, string locationDecoration) :base(name)
        {
            m_sDecoration = locationDecoration;
        }
        public override string Description
        {
            get
            {
                string description = base.Description;
                description += "Здесь вы видите: " + m_sDecoration + ". ";
                return description;
            }
        }

    }
}
