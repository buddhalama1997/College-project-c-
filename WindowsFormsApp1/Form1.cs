using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int loc_LeftDoor_open = 19;
        int loc_RightDoor_open = 170;
        int loc_LeftDoor_close = 69;
        int loc_RightDoor_close = 120;
        int upLift = 77;
        int downLift = 305;
        bool liftGoDown = false;
        bool liftGoUp = false;
        bool lift_At_1 = false;
        bool lift_At_0 = false;

        private void openUp()
        {
            tmr_upClose.Enabled = false;
            tmr_upOpen.Enabled = true;
        }
        private void closeUp()
        {
            tmr_upOpen.Enabled = false;
            tmr_upClose.Enabled = true;
        }

        private void openDown()
        {
            tmr_downClose.Enabled = false;
            tmr_downOpen.Enabled = true;
        }

        private void closeDown()
        {
            tmr_downClose.Enabled = true;
            tmr_downOpen.Enabled = false;
        }

        private void liftUp()
        {

            liftGoUp = true;
            closeDown();
            btnFloor0.Enabled = false;
            btnDownRequest.Enabled = false;
            btnDoorOpen.Enabled = false;
            btnDoorClose.Enabled = false;
            lift_At_0 = false;
        }

        private void liftDown()
        {
            liftGoDown = true;
            closeUp();
            btnFloor1.Enabled = false;
            btnUpRequest.Enabled = false;
            btnDoorOpen.Enabled = false;
            btnDoorClose.Enabled = false;
            lift_At_1 = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_upOpen_Tick(object sender, EventArgs e)
        {
            tmrUpOpenMethod();
        }
        private void tmrUpOpenMethod()
        {
            if (upLeftDoor.Left >= loc_LeftDoor_open && upRightDoor.Left <= loc_RightDoor_open)
            {
                upLeftDoor.Left -= 1;
                upRightDoor.Left += 1;

            }
            else
            {
                tmr_upOpen.Enabled = false;
                btnDoorOpen.BackColor = Color.White;
            }
        }
        private void tmr_upClose_Tick(object sender, EventArgs e)
        {
            tmrUpCloseMethod();
        }
        private void tmrUpCloseMethod()
        {
            if (upLeftDoor.Left <= loc_LeftDoor_close && upRightDoor.Left >= loc_RightDoor_close)
            {
                upLeftDoor.Left += 1;
                upRightDoor.Left -= 1;
            }
            else
            {
                tmr_upClose.Enabled = false;
                btnDoorClose.BackColor = Color.White;

                if (liftGoDown == true)
                {
                    tmr_liftDown.Enabled = true;
                    liftGoDown = false;
                }
            }
        }
        private void tmrDownOpenMethod()
        {
            if (downLeftDoor.Left >= loc_LeftDoor_open && downRightDoor.Left <= loc_RightDoor_open)
            {
                downLeftDoor.Left -= 1;
                downRightDoor.Left += 1;

            }
            else
            {
                tmr_downOpen.Enabled = false;
                btnDoorOpen.BackColor = Color.White;
            }
        }
        private void tmr_downOpen_Tick(object sender, EventArgs e)
        {
            tmrDownOpenMethod();
        }

        private void tmr_downClose_Tick(object sender, EventArgs e)
        {
            tmrDownCloseMethod();
        }
        private void tmrDownCloseMethod()
        {
            if (downLeftDoor.Left <= loc_LeftDoor_close && downRightDoor.Left >= loc_RightDoor_close)
            {
                downLeftDoor.Left += 1;
                downRightDoor.Left -= 1;
            }
            else
            {
                tmr_downClose.Enabled = false;
                btnDoorClose.BackColor = Color.White;

                if (liftGoUp == true)
                {
                    tmr_liftUp.Enabled = true;
                    liftGoUp = false;
                }
            }
        }
        private void tmr_liftUp_Tick(object sender, EventArgs e)
        {
            if (lift.Top > upLift)
            {
                lift.Top -= 1;

            }
            else
            {
                tmr_liftUp.Enabled = false;
                btnDownRequest.Enabled = true;
                btnFloor0.Enabled = true;
                btnDoorClose.Enabled = true;
                btnDoorOpen.Enabled = true;
                btnFloor1.BackColor = Color.White;
                btnUpRequest.BackColor = Color.White;
                openUp();
                lift_At_1 = true;
            }
        }

        private void tmr_liftDown_Tick(object sender, EventArgs e)
        {
            if (lift.Top < downLift)
            {
                lift.Top += 1;
            }
            else
            {
                tmr_liftDown.Enabled = false;
                btnUpRequest.Enabled = true;
                btnFloor1.Enabled = true;
                btnDoorClose.Enabled = true;
                btnDoorOpen.Enabled = true;
                btnDownRequest.BackColor = Color.White;
                btnFloor0.BackColor = Color.White;

                openDown();
                lift_At_0 = true;
            }
        }
        private void doorOpen()
        {
            btnDoorOpen.BackColor = Color.Red;
            if (lift_At_0 == true)
            {
                openDown();
            }
            else if (lift_At_1 == true)
            {

                openUp();
            }
        }

        private void btnDoorOpen_Click(object sender, EventArgs e)
        {
            doorOpen();
        }
        private void doorClose()
        {
            btnDoorClose.BackColor = Color.Red;
            if (lift_At_0 == true)
            {
                closeDown();
            } else if (lift_At_1 == true)
            {
                closeUp();
            }
        }

        private void btnDoorClose_Click(object sender, EventArgs e)
        {
            doorClose();
        }

        private void btnFloor0_Click(object sender, EventArgs e)
        {
            btnFloor0.BackColor = Color.Red;
            liftDown();
            liftPosition0();
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            btnFloor1.BackColor = Color.Red;
            liftUp();
            liftPosition1();
        }

        private void btnDownRequest_Click(object sender, EventArgs e)
        {
            btnFloor0.BackColor = Color.Red;
            liftDown();
            liftPosition0();
        }

        private void btnUpRequest_Click(object sender, EventArgs e)
        {
            btnFloor1.BackColor = Color.Red;
            liftUp();
            liftPosition1();
        }
        private void liftPosition1()
        {
            liftLocation.Text.Remove(0);
            liftLocation.Text = "1";
            label5.Text.Remove(0);
            label5.Text = "1";
            label2.Text.Remove(0);
            label2.Text = "1";
            
        }
        private void liftPosition0()
        {
            liftLocation.Text.Remove(0);
            liftLocation.Text = "0";
            label5.Text.Remove(0);
            label5.Text = "0";
            label2.Text.Remove(0);
            label2.Text = "0";
        }
    }
}
