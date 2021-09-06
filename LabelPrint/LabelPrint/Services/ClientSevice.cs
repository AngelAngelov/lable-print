using CoreHtmlToImage;
using LabelPrint.Data;
using LabelPrint.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace LabelPrint.Services
{
    public class ClientService
    {
        private readonly DB _context;
        public ClientService() 
        {
            _context = new DB();
        }

        /*
         * 1. трябва да се направи метод (Print), който приема 2 параметъра - ID на клиент и Шаблон (template) за генериране на резултата.
         * 2. Трябва да се намери клиента в базата (_context.Clients). Изполвай linq за да го намериш.
         * 3. Трябва да се заменят ключовите думи в шаблона с данните от базата 
         * 4. Трябва да се генерира катинка (jpeg, png, ...), в която да се съдържа текста от шаблона
         * 5. Картинката трябва да се върне като резулт от метода
         */


        public byte[] Print(int clientId, string template)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == clientId);
            template = template.Replace("#name#", client.Name);
            
            var html = "<!DOCTYPE html> <html lang = \"en\"><head><meta charset=\"UTF-8\" ></head ><body>"
                + template + "</body ></html >";


            var result = DrawImageFromHTML(html);

            return result;
        }

        private byte[] DrawImageFromHTML(string html) 
        {
            var converter = new HtmlConverter();
            var bytes = converter.FromHtmlString(html, 200);
            //File.WriteAllBytes("image.jpg", bytes);

            return bytes;
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }
    }
}
