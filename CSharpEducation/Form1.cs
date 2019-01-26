using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEducation
{
    public partial class Form1 : Form
    {
        COutsideWithDoor lawn,backyard;
        CRoomWithDoor kitchen, livingRoom;
        CRoom canteen;
        COutside garden;
        ACLocation currentLocation;
        public Form1()
        {
            InitializeComponent();
            createObjects();
            cmbxLocations.DisplayMember="Name";
            moveToNewLocation(livingRoom);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            ACLocation nextLoc = cmbxLocations.SelectedItem as ACLocation;
            if (nextLoc != null)
            {
                moveToNewLocation(nextLoc);
            }
        }

        private void btnGoOutside_Click(object sender, EventArgs e)
        {
            ACLocation nextLoc = (currentLocation as IHasExteriorDoor).DoorLocation;
            if (nextLoc != null)
            {
                moveToNewLocation(nextLoc);
            }
        }

        void moveToNewLocation(ACLocation location)
        {
            currentLocation = location;
            cmbxLocations.Items.Clear();

            foreach(ACLocation locExit in currentLocation.Exits)
            {
                cmbxLocations.Items.Add(locExit);
            }
            tbxDescription.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
            {
                btnGoOutside.Enabled = true;
            }
            else
            {
                btnGoOutside.Enabled = false;
            }
            cmbxLocations.SelectedIndex = 0;
            
        }
        void createObjects()
        {
            lawn = new COutsideWithDoor("Лужайка", true, " дубовая дверь с латунной ручкой");
            backyard = new COutsideWithDoor("Задний двор", false, "сетчатая дверь");
            kitchen = new CRoomWithDoor("Кухня", " плита из нержавеющей стали", " сетчатая дверь");
            livingRoom= new CRoomWithDoor("Гостиная", " старинный ковер", "дубовая дверь с латунной ручкой");
            canteen = new CRoom("Столовая", " хрустальная люстра");
            garden = new COutside("Сад");

            lawn.DoorLocation = livingRoom;
            backyard.DoorLocation = kitchen;
            kitchen.DoorLocation = backyard;
            livingRoom.DoorLocation = lawn;

            lawn.addExit(garden);
            lawn.addExit(backyard);

            livingRoom.addExit(canteen);            

            canteen.addExit(livingRoom);
            canteen.addExit(kitchen);

            kitchen.addExit(canteen);

            backyard.addExit(garden);
            backyard.addExit(lawn);

            garden.addExit(backyard);
            garden.addExit(lawn);

        }
    }
}
