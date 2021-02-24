using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrowaveApp
{
    class ImageGenerator
    {

        private PictureBox _pictureBox;
        private string _microwaveImage = "images/Microwave.jpg";
        public string MicrowaveImage
        {
            get
            {
                return _microwaveImage;
            }
            set
            {
                _microwaveImage = value;
                generateAndSetImage();
            }
        }
        private string _foodImage = "FoodElements/Img/burger.png";

        public string FoodImage
        {
            get
            {
                return _foodImage;
            }
            set
            {
                _foodImage = value;
                generateAndSetImage();
            }
        }
        private string _lampImage = "images/lamp_off.png";

        public string LampImage
        {
            get
            {
                return _lampImage;
            }
            set
            {
                _lampImage = value;
                generateAndSetImage();
            }
        }

        public ImageGenerator(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
        }

        public void generateAndSetImage()
        {
            string[] f = { _microwaveImage, _foodImage, _lampImage };
            _pictureBox.Image = CombineBitmap(f);
        }

        /// <summary>
        /// modified https://stackoverflow.com/a/11472998/13000688
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public static System.Drawing.Bitmap CombineBitmap(string[] files)
        {
            //read all images into memory
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap finalImage = null;

            try
            {
                int width = 500;
                int height = 500;

                foreach (string image in files)
                {
                    //create a Bitmap from the file and add it to the list
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //update the size of the final bitmap
                    // width += bitmap.Width;
                    // height = bitmap.Height > height ? bitmap.Height : height;

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new System.Drawing.Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(System.Drawing.Color.Transparent);

                    //go through each image and draw it on the final image
                    foreach (System.Drawing.Bitmap image in images)
                    { 
                        g.DrawImage(image, new System.Drawing.Rectangle(0, 0, image.Width, image.Height));
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (System.Drawing.Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }

    }
}
