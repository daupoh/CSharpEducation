using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    abstract class ACLocation
    {
        protected string m_sName;
        protected ACLocation[] m_apExits;

        public string Name {
            get {
               return m_sName;               
            }
        }
        ACLocation[] Exits {
            get
            {
                return m_apExits;
            }
        }
        public virtual string Description
        {
            get
            {
                string description = "Вы находитесь в " + m_sName + ". Вы видите двери, ведущие в: ";
                for (int i = 0; i < m_apExits.Length; i++)
                {
                    description += " " + m_apExits[i].Name;
                    if (i!= m_apExits.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }

        public ACLocation (string name)
        {
            checkName(name);
            m_sName = name;
           
        }
        
        public void addExit(ACLocation newExit)
        {
            checkExit(newExit);
            int newSize = m_apExits.Length + 1;
            resizeArrayOfExits(newSize);
            m_apExits[newSize - 1] = newExit;
        }
        public bool Equals(ACLocation loc)
        {
            bool isEqual = false;
            isEqual = this.Name == loc.Name;
            if (isEqual)
            {
                foreach (ACLocation thisExit in this.Exits)
                {
                    bool hasMatch = false;
                    foreach (ACLocation locExit in loc.Exits)
                    {
                        if (thisExit.Name == locExit.Name)
                        {
                            hasMatch = true;
                            break;
                        }
                    }
                    if (!hasMatch)
                    {
                        isEqual = false;
                    }
                }
            }
            return isEqual;
        }

        private void resizeArrayOfExits(int newSize)
        {
            ACLocation[] newExits = new ACLocation[newSize];
            uint index = 0;
            foreach(ACLocation exit in m_apExits)
            {
                newExits[index++] = exit;
            }
            m_apExits = null;
            m_apExits = newExits;
        }
        private void checkName(string name)
        {
            if (name==null || name=="")
            {
                throw new FormatException("Имя не должно быть пустым.");
            }
           
        }
        private void checkExit(ACLocation exit)
        {
            if (exit==null)
            {
                throw new FormatException("Новый выход не может быть пустым объектом.");
            }
            if (exit.Equals(this))
            {
                throw new FormatException("Рекурсия - локация имеет выход на саму себя.");
            }
            foreach(ACLocation existExit in m_apExits)
            {
                if (existExit.Equals(exit))
                {
                    throw new FormatException("Выход уже существует и не может быть добавлен повторно.");
                }
            }
        }
    }
}
