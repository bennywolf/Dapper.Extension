using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QRCoder.PayloadGenerator;

namespace Common.Library.File
{
    public class QrCodeUtil
    {
        /// <summary>
        /// 创建普通文本二维码
        /// </summary>
        /// <param name="text"></param>
        public static void Text(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save("D:\\aa.png");
        }
        /// <summary>
        /// URL跳转二维码
        /// </summary>
        public static void URL(string url)
        {
            var payload = new Url(url);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save("D:\\aa.png");
        }
        /// <summary>
        /// 扫一扫连接二维码
        /// </summary>
        public static Bitmap WiFi(string name,string password)
        {
            var payload = new WiFi(name, password, PayloadGenerator.WiFi.Authentication.WPA,false);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20,Color.Black,Color.White,(Bitmap)Bitmap.FromFile("D:\\aa.jpg"));
            return qrCodeImage;
        }
    }
}
