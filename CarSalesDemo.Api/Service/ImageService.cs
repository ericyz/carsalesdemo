using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using CarSalesDemo.Api.Service.Interface;

namespace CarSalesDemo.Api.Service {
    public class ImageService : IImageService {
        private string _baseFolderPath;

        public ImageService(string baseFolderPath) {
            this._baseFolderPath = baseFolderPath;
        }

        public byte[] LoadImage(string fileName) {
            var filePath = $"{_baseFolderPath}{fileName}";
            return File.ReadAllBytes(filePath); 
//            return new StreamContent(stream); 
        }

 

//        private static ImageCodecInfo GetEncoderInfo(string mimeType) {
//            // Get image codecs for all image formats 
//            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
//
//            // Find the correct image codec 
//            for (int i = 0; i < codecs.Length; i++)
//                if (codecs[i].MimeType == mimeType)
//                    return codecs[i];
//            return null;
//        }
//
//        public static FileStream ProcessImage(string filePath, int quality) {
//            if (quality < 0 || quality > 100)
//                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");
//
//
//            // Encoder parameter for image quality 
//            Image image = Image.FromFile(filePath);
//            EncoderParameter qualityParam =
//                new EncoderParameter(Encoder.Quality, quality);
//            // Jpeg image codec 
//            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
//
//            EncoderParameters encoderParams = new EncoderParameters(1);
//            encoderParams.Param[0] = qualityParam;
//            FileStream outStream = new FileStream(filePath, FileMode.Open);
//            image.Save(outStream, jpegCodec, encoderParams);
//            return outStream;
//        }
    }
}