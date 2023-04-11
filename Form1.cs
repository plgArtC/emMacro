using System;

namespace emMacro
{
    public partial class Form1 : Form
    {

        int DelayTime = 1000;
        int ifMinu = 1000;
        public Form1()
        {
            InitializeComponent();
        }
        bool activeMacro = false;

        private void startStopButton_Click(object sender, EventArgs e)
        {

            activeMacro = !activeMacro;
            timer2.Interval= DelayTime;
            if (activeMacro) {
                startStopButton.Text = "STOP";
                     }
            else
            {
                startStopButton.Text = "START";
            }
        }
        String MacroKey;

        private void GenTimer_Tick(object sender, EventArgs e)
        {
            
            stateText.Text =" State : "+activeMacro.ToString();
            if(activeMacro)
            {
                MacroKey = IntoMacroKey.Text.Substring(0);
                
            }
            timer2.Enabled = activeMacro;
        }

        private void IntoMacroKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(activeMacro) 
            {
                SendKeys.Send(MacroKey);
            }
        }






        


        void timeSettings(int dTime, bool isPls, bool isMin)
        {

            
            if (isMin) { ifMinu = 60000; }
            if (!isMin) { ifMinu = 1000; }

           
                if (isPls)
                {
                DelayTime = Math.Clamp(DelayTime + dTime, 1000, 600000);
                }
                if (!isPls)
                {
                DelayTime = Math.Clamp(DelayTime - dTime, 1000, 600000);
                }
                DelayText.Text = (DelayTime/1000).ToString() + " Sn.";
                timer2.Interval = DelayTime;


        }
        private void SecPlus_Click(object sender, EventArgs e)
        {
            timeSettings(1000, true,false);
        }

        private void decSec_Click(object sender, EventArgs e)
        {
            timeSettings(1000,false, false);
        }

        private void plusMin_Click(object sender, EventArgs e)
        {
            timeSettings(60000, true,true);
        }

        private void decMin_Click(object sender, EventArgs e)
        {
            timeSettings(60000, false,true);
        }

        private void DefaultBtn_Click(object sender, EventArgs e)
        {
            DelayTime = 1000;
            DelayText.Text = (DelayTime / 1000).ToString() + " Sn.";
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            IntoMacroKey.Text = "";
        }
    }
}