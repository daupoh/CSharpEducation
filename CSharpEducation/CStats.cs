using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    class CStats
    {
        int m_iTotal = 0, m_iMissed = 0, m_iCorrect = 0, m_iAccurecy = 0;

        public int Total { get { return m_iTotal; } }
        public int Missed { get { return m_iMissed; } }
        public int Correct { get { return m_iCorrect; } }
        public int Accuracy { get { return m_iAccurecy; } }

        public void Update(bool correctKey)
        {
            m_iTotal++;
            if (!correctKey)
            {
                m_iMissed++;
            }
            else
            {
                m_iCorrect++;
            }

            m_iAccurecy = 100 * m_iCorrect / (m_iMissed + m_iCorrect);
        }
    }
}
