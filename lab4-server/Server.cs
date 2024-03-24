using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

class Server
{
    static void Main(string[] args)
    {
        var listener = new HttpListener();
        listener.Prefixes.Add("http://127.0.0.1:8888/");
        listener.Start();


        Console.WriteLine("Сервер запущен");
        while (true)
        {
            //информация о запросе
            var context = listener.GetContext();

            var request = context.Request;
            var response = context.Response;

            int lenght=int.Parse(request.Headers["Content-Length"]);

            Stream input = request.InputStream;
            Stream output = response.OutputStream;
            byte[] buffer=new byte[lenght];

            input.Read(buffer, 0, lenght);
            var str = System.Text.Encoding.Default.GetString(buffer);
            
            //тело запроса
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(str);

            string methodName = xml.GetElementsByTagName("methodName")[0].InnerText;

            if (methodName == "matrixHandle")
            {
                IMatrixServiceServer service = new MatrixService();

                //извлечение параметров запроса
                int[][] matrix=service.getMatrixFromXml(xml);

                //вызов сервиса
                int[][] result = service.matrixHandle(matrix);

                //формирование ответа на запрос
                string ans = service.getResponseBody(result);

                response.ContentLength64 = ans.Length;
                response.ContentType = "text/xml";
                response.KeepAlive = false;

                //отправка ответа
                byte[] ansBuffer = Encoding.UTF8.GetBytes(ans);
                output.Write(ansBuffer, 0, ans.Length);

                output.Flush();

            }

            Console.WriteLine("Запрос обработан");
        }
    }
}

