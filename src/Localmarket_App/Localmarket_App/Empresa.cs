using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Localmarket_App
{
    public class Empresa
    {
        private string CIF;
        private string name;
        private string category;
        private string email;
        private int phone;
        private double avgScore;
        private Image profilePicture;
        private string address;
        private int cp;
        private string description;
        private string usuario;

        public Empresa(string cif, string name, string category, string email, 
            int phone, double avgscore ,Image image, string address, int cp, string description, string username)
        {
            this.CIF = cif;
            this.name = name;
            this.category = category;
            this.email = email;
            this.phone = phone;
            this.avgScore = avgscore;
            this.profilePicture = image;
            this.address = address;
            this.cp = cp;
            this.description = description;
            this.usuario = username;
        }

        public string Name { get { return name; } }
        public Image ProfilePicture { get { return profilePicture; } }
        public string Description { get { return description; } }
        public double AvgScore { get { return avgScore; } }
        public string Address { get { return address; } }

        public static string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

    }
}