using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    class COutside:ACLocation
    {
        protected bool m_bHot;

        public COutside(string name):base(name)
        {
            m_bHot = false;
            
        }
        public bool Hot { get { return m_bHot; } }
        public override string Description
        {
            get
            {
                string description = base.Description;
                if (m_bHot)
                {
                    description += "Тут очень жарко. ";
                }
                else
                {
                    description += "Тут прохладно. ";
                }
                return description;
            }
        }
    }
}
