using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WEB_API.Controller
{
                                              /*Using of Constrains in API*/

       [ApiController]
       public class BooksController : ControllerBase
       {
        [Route("id/{id}")]
            public string GetById(int id)
            {
                return "your id: " +id;
            }
       
        
        [Route("{name}")]
             public string GetByIdString(string name)
             {
                 return "hello MR. " + name;
             }

        [Route("max/{inr:int:max(100)}")]
           public string GetByIdNumber(int inr)
           {
              return "maximum price INR " + inr;
           }

        [Route("min/{inr:int:min(10)}")]
           public string GetMin(int inr)
           {
               return "minimum price INR " + inr;
           }

        [Route("min/max/{inr:int:min(50):max(80)}")]
           public string GetMinMaxLength(int inr)
           {
               return "Minimum and Maximum price INR " + inr;
           }

        [Route("length/{value:length(10)}")]
            public string GetLength(int value)
        {
            return "length 10(value):" + value;
        }

        [Route("value/{value:length(5):alpha}")]
           public string GetAlphaNumeric(string value) 
           {
            return "5 Alphabet:" + value;
           }

        [Route("{value:regex(a(m|n)s)}")]
            public string GetIdByRegex(string value)
            {
               return "Regex:" + value+"h";
            }

       }



    
}
