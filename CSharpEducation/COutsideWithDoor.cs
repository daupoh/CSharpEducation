using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducation
{
    class COutsideWithDoor:COutside,IHasExteriorDoor
    {
        string m_sDoorDescription;
        ACLocation m_pDoorLocation;

        public COutsideWithDoor(string name, bool hot, string doorDescription)
            :base(name)
        {
            m_bHot = hot;
            m_sDoorDescription = doorDescription;
           
        }
        public override string Description
        {
            get
            {
                string description = base.Description;
               
                description += "Вы видите дверь внутрь дома: " + m_sDoorDescription + ". ";
                
                return description;
            }
        }
        public string DoorDescription { get { return m_sDoorDescription; } }
        public ACLocation DoorLocation
        {
            get { return m_pDoorLocation; }
            set { m_pDoorLocation = value; }
         }
    }
}
