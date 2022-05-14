using System;
using System.IO;
using System.Net;
using System.Xml;

namespace SoapClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of program class to access methods  
            Program obj = new Program();
            Console.WriteLine("Please Enter Input values..");

            /*
            Console.WriteLine("Usuário");
            string user = Console.ReadLine().ToString();
            Console.WriteLine("Senha");
            string password = Console.ReadLine().ToString();
            */

            string user = "senior";
            string password = "senior";

            var resposta = obj.InvokeService(user, password);

            if (resposta == 0)
            {
                Console.WriteLine("Login efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos!");
            }

        }
        public int InvokeService(string user, string password)
        {
            //Calling CreateSOAPWebRequest method  
            HttpWebRequest request = CreateSOAPWebRequest();

            XmlDocument SOAPReqBody = new XmlDocument();

            SOAPReqBody.LoadXml(@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" 
                    xmlns:ser = ""http://services.senior.com.br"" >
                    <soapenv:Body>
                    <ser:AuthenticateJAAS>
                        <user>" + user + @"</user>
                        <password>" + password + @"</password>
                        <encryption>0</encryption>
                     <parameters>
                            <pmUserName>" + user + @"</pmUserName>
                            <pmUserPassword>" + password + @"</pmUserPassword>
                            <pmEncrypted>0</pmEncrypted>
                          </parameters>
                    </ser:AuthenticateJAAS>
                </soapenv:Body>
            </soapenv:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }
            //Geting response from request  
            using (WebResponse Serviceres = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                {
                    //reading stream  
                    var ServiceResult = rd.ReadToEnd();


                    return Convert.ToInt32(ServiceResult);
                    //writting stream result on console  
                    Console.WriteLine(ServiceResult);
                    Console.ReadLine();
                }
            }
        }

        public HttpWebRequest CreateSOAPWebRequest()
        {
            //Making Web Request  
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://localhost:8080/g5-senior-services/sapiens_SyncMCWFUsers?wsdl");
            //SOAPAction  
            //Req.Headers.Add(@"SOAPAction:http://tempuri.org/Addition");
            //Content_type  
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method  
            Req.Method = "POST";
            //return HttpWebRequest  
            return Req;
        }
    }
}
