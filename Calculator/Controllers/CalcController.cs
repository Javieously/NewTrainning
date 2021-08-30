using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View();
        }

        public string getResult(string Result)
        {
            List<char> symbleList = new List<char>();
            char[] charSymble = { '+', '-', '*', '/' };
            string[] st = Result.Split(charSymble);
            for (int i = 0; i < Result.Length; i++)
            {
                if (Result[i] == '+' || Result[i] == '-' || Result[i] == '*' || Result[i] == '/')
                {
                    symbleList.Add(Result[i]);
                }
            }
            double result = Convert.ToDouble(st[0]);
            for (int i = 1; i < st.Length; i++)
            {
                double num = Convert.ToDouble(st[i]);
                int j = i - 1;
                switch (symbleList[j])
                {
                    case '+':
                        result = result + num;
                        break;
                    case '-':
                        result = result - num;
                        break;
                    case '*':
                        result = result * num;
                        break;
                    case '/':
                        result = result / num;
                        break;
                    default:
                        result = 0.0;
                        break;
                }
            }
            return result.ToString();


        }

    
    }

}