using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class RightDisp
    {
        public static string[] DispDataRight(string strData)  
        {
string[] str = { };
switch (strData)
            {
case"000": str = new string[] { "KeyA|B", "KeyA|B", "KeyA|B", "KeyA|B" }; break;
case"010": str = new string[] { "KeyA|B", "Never", "Never", "Never" }; break;
case"100": str = new string[] { "KeyA|B", "KeyB", "Never", "Never" }; break;
case"110": str = new string[] { "KeyA|B", "KeyB", "KeyB", "KeyA|B" }; break;
case"001": str = new string[] { "KeyA|B", "Never", "Never", "KeyA|B" }; break;
case"011": str = new string[] { "KeyB", "KeyB", "Never", "Never" }; break;
case"101": str = new string[] { "KeyB", "Never", "Never", "Never" }; break;
case"111": str = new string[] { "Never", "Never", "Never", "Never" }; break;
            }
return str;
        }
        public static string[] DispControlRight(string strControl)
        {
string[] str = { };
switch (strControl)
            {
case"000": str = new string[] { "Never", "KeyA|B", "KeyA|B", "Never", "KeyA|B", "KeyA|B" }; break;
case"010": str = new string[] { "Never", "Never", "KeyA|B", "Never", "KeyA|B", "Never" }; break;
case"100": str = new string[] { "Never", "KeyB", "KeyA|B", "Never", "Never", "KeyB" }; break;
case"110": str = new string[] { "Never", "Never", "KeyA|B", "Never", "Never", "Never" }; break;
case"001": str = new string[] { "Never", "KeyA|B", "KeyA|B", "KeyA|B", "KeyA|B", "KeyA|B" }; break;
case"011": str = new string[] { "Never", "KeyB", "KeyA|B", "KeyB", "Never", "KeyB" }; break;
case"101": str = new string[] { "Never", "Never", "KeyA|B", "KeyB", "Never", "Never" }; break;
case"111": str = new string[] { "Never", "Never", "KeyA|B", "Never", "Never", "Never" }; break;
            }
return str;
        }

    }
}
