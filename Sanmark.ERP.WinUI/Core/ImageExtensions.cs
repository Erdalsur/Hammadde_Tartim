using Kaliko.ImageLibrary;
using Kaliko.ImageLibrary.Filters;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Sanmark.ERP.WinUI.Core
{
    public static class ImageExtensions
    {
        public static Image Resize(this Image img, int size)
        {
            //a holder for the result
            Bitmap result = new Bitmap(size, size);
            //set the resolutions the same to avoid cropping due to resolution differences
            result.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap
                graphics.DrawImage(img, 0, 0, result.Width, result.Height);
            }

            return result as Image;
        }

        public static Image ResizeA4(this Image img, int size)
        {
            //a holder for the result
            Bitmap result = new Bitmap(size, (int)(size * img.Height / img.Width));
            //set the resolutions the same to avoid cropping due to resolution differences
            result.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap
                graphics.DrawImage(img, 0, 0, result.Width, result.Height);
            }

            return result as Image;
        }


        public static Bitmap ToBitmap(this byte[] bytes)
        {
            Bitmap bitmap = null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                bitmap = (Bitmap)Image.FromStream(ms);
            }
            return bitmap;
        }



        public static Image Resize(this Image img, double percentage)
        {
            //a holder for the result
            Bitmap result = new Bitmap(Convert.ToInt32(img.Width * percentage), Convert.ToInt32(img.Height * percentage));
            //set the resolutions the same to avoid cropping due to resolution differences
            result.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap
                graphics.DrawImage(img, 0, 0, result.Width, result.Height);
            }

            return result as Image;
        }

        public static void SaveAsJPEG(this Image img, string imagePath)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            ImageCodecInfo jgpEncoder = null;

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == ImageFormat.Jpeg.Guid)
                {
                    jgpEncoder = codec;
                    break;
                }
            }

            Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters encoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
            EncoderParameter encoderParameter = new EncoderParameter(encoder, 100L);
            encoderParameters.Param[0] = encoderParameter;

            img.Save(imagePath, jgpEncoder, encoderParameters);
        }

        public static byte[] ToByteArray(this Image img)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            img.Save(memoryStream, img.RawFormat);
            return memoryStream.ToArray();
        }


        public static Image Unsharpen(this Image img, float strength = 0.4F)
        {
            //KalikoImage sharpimg = new KalikoImage(img).GetThumbnailImage(427, 284, ThumbnailMethod.Fit);
            //sharpimg.ApplyFilter(new UnsharpMaskFilter(1.2, 0.3));
            //sharpimg.SaveJpg(pathT, 95);

            return new KalikoImage(img).Unsharpen(strength);
        }

        public static Image Unsharpen(this KalikoImage img, float strength = 0.4F)
        {
            img.ApplyFilter(new UnsharpMaskFilter(1.2F, strength, 20));   //threshold: http://www.damiensymonds.com.au/tut_usm.html

            MemoryStream ms = new MemoryStream();
            img.SaveJpg(ms, 90);
            return Image.FromStream(ms);
        }

        public static byte[] ToPNG(this Image img)
        {
            byte[] bytes;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Png);
                    bytes = ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bytes;
        }

        public static byte[] ToJPEG(this Image img)
        {
            byte[] bytes;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    bytes = ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bytes;
        }

        public static Image CropFromCenter(this Image bmp, int size)
        {
            Rectangle cropRect = new Rectangle((bmp.Width / 2) - (size / 2), (bmp.Height / 2) - (size / 2), size, size);

            Bitmap target = new Bitmap(size, size);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(bmp, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);
            }

            return target;
        }

        public static Image Mask(this Image img, Bitmap mask)
        {
            Bitmap target = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(target);
            graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            graphics.DrawImage(img, 0, 0);
            graphics.DrawImage(mask, 0, 0);

            return target;
        }

        public static Bitmap Crop(this Bitmap bmp, Rectangle rect)
        {
            Bitmap modified = new Bitmap(rect.Width, rect.Height);
            Graphics g = Graphics.FromImage(modified);
            g.DrawImage(bmp, -rect.X, -rect.Y);

            return modified;
        }
    }
}
