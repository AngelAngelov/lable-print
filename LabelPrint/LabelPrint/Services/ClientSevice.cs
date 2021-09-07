using LabelPrint.Data;

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
    }
}
