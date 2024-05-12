using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public static class XuLiHinhAnh
    {
        public static byte[] AnhSangByte(Image image)
        {
            if (image == null)
            {
                return new byte[0]; // Empty byte array for error case
            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image: " + ex.Message);
                return new byte[0]; // Empty byte array for error case
            }
        }

        public static Image ByteSangAnh(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null; // Indicate error by returning null
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting bytes to image: " + ex.Message);
                return null; // Indicate error by returning null
            }
        }

        public static Image MoFileTaiAnh()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(openFileDialog.FileName)))
                    {
                        return Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                    return null;
                }
            }
            return null;
        }
    }
}