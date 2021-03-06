﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveCoody.expression
{
    class Base64Expression
    {

        public static string base64Decode(String context,String encode) {
           byte[] result =Convert.FromBase64String(context);
           return Encoding.GetEncoding(encode).GetString(result);
        }

        public static string base64Encode(String context, String encode)
        {
          byte[] contextBytes= Encoding.GetEncoding(encode).GetBytes(context);
          return Convert.ToBase64String(contextBytes);   
        }
    }
}
