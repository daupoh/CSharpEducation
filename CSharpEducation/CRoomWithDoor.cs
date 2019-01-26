using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    class CRoomWithDoor:CRoom,IHasExteriorDoor
    {
        string m_sDoorDescription;
        ACLocation m_pDoorLocation;

        public CRoomWithDoor(string name, string locationDecoration, string doorDescription)
            :base(name,locationDecoration)
        {           
            m_sDoorDescription = doorDescription;          

        }
        public override string Description
        {
            get
            {
                string description = base.Description;
                description += "Вы видите дверь наружу: " + m_sDoorDescription + ". ";
                return description;
            }
        }
        public string DoorDescription { get { return m_sDoorDescription; } }
        public ACLocation DoorLocation { get { return m_pDoorLocation; } set { m_pDoorLocation = value; } }
    }
}
