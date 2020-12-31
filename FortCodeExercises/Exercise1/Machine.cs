using System.Text;

namespace FortCodeExercises.Exercise1
{
    public class Machine
    {
        private string MachineName = "";
        private int Type = 0;

        public string GetName()
        {
            string machineName = "";
            if (!string.IsNullOrEmpty(MachineName)) 
                return machineName;
            switch (this.Type)
            {
                case 0:
                    machineName = "bulldozer";
                    break;
                case 1:
                    machineName = "crane";
                    break;
                case 2:
                    machineName = "tractor";
                    break;
                case 3:
                    machineName = "truck";
                    break;
                case 4:
                    machineName = "car";
                    break;
            }
            return machineName;
        }

        public string GetDescription()
        {
            bool hasMaxSpeed = true;
            switch (this.Type)
            {
                case 1:
                case 2:
                    hasMaxSpeed = true;
                    break;
                case 3:
                case 4:
                    hasMaxSpeed = false;
                    break;
            }
            StringBuilder description = new StringBuilder();
            description.Append("");
            description.Append(" ");
            description.Append(this.GetColor() + " ");
            description.Append(this.GetName());
            description.Append(" ");
            description.Append("[");
            description.Append(this.GetMaxSpeed(this.Type, hasMaxSpeed) + "].");
            return description.ToString();
        }

        public string GetColor()
        {
            string color = "white";
            switch (this.Type)
            {
                case 0:
                    color = "red";
                    break;
                case 1:
                    color = "blue";
                    break;
                case 2:
                    color = "green";
                    break;
                case 3:
                    color = "yellow";
                    break;
                case 4:
                    color = "brown";
                    break;
                default:
                    color = "white";
                    break;
            }
            return color;
        }

        public string GetTrimColor()
        {
            string baseColor = "white";
            switch (this.Type)
            {
                case 0:
                    baseColor = "red";
                    break;
                case 1:
                    baseColor = "blue";
                    break;
                case 2:
                    baseColor = "green";
                    break;
                case 3:
                    baseColor = "yellow";
                    break;
                case 4:
                    baseColor = "brown";
                    break;
                default:
                    baseColor = "white";
                    break;
            }

            string trimColor = "";
            switch (this.Type)
            {
                case 1 when this.IsDark(baseColor):
                    trimColor = "black";
                    break;
                case 1 when !this.IsDark(baseColor):
                    trimColor = "white";
                    break;
                case 2 when this.IsDark(baseColor):
                    trimColor = "gold";
                    break;
                case 3 when this.IsDark(baseColor):
                    trimColor = "silver";
                    break;
            }
            return trimColor;
        }

        public bool IsDark(string color)
        {
            bool isDark = false;
            switch (color)
            {
                case "green":
                case "black":
                case "red":
                case "crimson":
                    isDark = true;
                    break;
                case "white":
                case "beige":
                case "babyblue":
                case "yellow":
                    isDark = false;
                    break;
            }
            return isDark;
        }

        public int GetMaxSpeed(int machineType, bool noMax = false)
        {
            int max = 70;
            if (machineType == 1 && noMax == false) max = 70;
            else if (noMax == false && machineType == 2) max = 60;
            else if (machineType == 0 && noMax == true) max = 80;
            else if (machineType == 2 && noMax == true) max = 90;
            else if (machineType == 4 && noMax == true) max = 90;
            else if (machineType == 1 && noMax == true) max = 75;
            return max;
        }
    }
}