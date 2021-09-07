using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabelPrint.Models
{
    public class PicResponceModel
    {
        //име на файла 
        public string Filename { get; set; }
        //медиа типа на файла
        public string Mimetype { get; set; }
        //base64 encode-нат стринг на съдържанието на файла
        public string Data { get; set; }
    }
}
